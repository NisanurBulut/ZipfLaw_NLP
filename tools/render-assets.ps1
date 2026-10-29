# Renders tools/logo.xaml to docs/images/zipfomancy-logo.png (512 px) and src/ZipfLaw.Wpf/Assets/zipfomancy.ico (the app icon).
# Run with: powershell -STA -File tools/render-assets.ps1
Add-Type -AssemblyName PresentationCore, PresentationFramework, WindowsBase

$root = Split-Path $PSScriptRoot -Parent
$xaml = Join-Path $PSScriptRoot 'logo.xaml'
$images = Join-Path $root 'docs\images'

function Save-Logo($size, $path) {
    # A fresh copy each time: an element can only live in one Viewbox.
    $canvas = [System.Windows.Markup.XamlReader]::Load([System.IO.File]::OpenRead($xaml))
    $box = New-Object System.Windows.Controls.Viewbox
    $box.Width = $size
    $box.Height = $size
    $box.Child = $canvas
    $box.Measure((New-Object System.Windows.Size $size, $size))
    $box.Arrange((New-Object System.Windows.Rect 0, 0, $size, $size))
    $box.UpdateLayout()

    $bitmap = New-Object System.Windows.Media.Imaging.RenderTargetBitmap $size, $size, 96, 96, ([System.Windows.Media.PixelFormats]::Pbgra32)
    $bitmap.Render($box)
    $encoder = New-Object System.Windows.Media.Imaging.PngBitmapEncoder
    $encoder.Frames.Add([System.Windows.Media.Imaging.BitmapFrame]::Create($bitmap))
    $stream = [System.IO.File]::Create($path)
    $encoder.Save($stream)
    $stream.Close()
}

Save-Logo 512 (Join-Path $images 'zipfomancy-logo.png')

# Icon with PNG-compressed entries
$sizes = 16, 32, 48, 64, 128, 256
$pngs = @()
foreach ($size in $sizes) {
    $temp = [System.IO.Path]::GetTempFileName()
    Save-Logo $size $temp
    $pngs += , ([System.IO.File]::ReadAllBytes($temp))
    Remove-Item $temp
}
$ico = New-Object System.IO.MemoryStream
$writer = New-Object System.IO.BinaryWriter $ico
$writer.Write([uint16]0)
$writer.Write([uint16]1)
$writer.Write([uint16]$sizes.Count)
$offset = 6 + 16 * $sizes.Count
for ($i = 0; $i -lt $sizes.Count; $i++) {
    $dimension = if ($sizes[$i] -ge 256) { 0 } else { $sizes[$i] }
    $writer.Write([byte]$dimension)
    $writer.Write([byte]$dimension)
    $writer.Write([byte]0)
    $writer.Write([byte]0)
    $writer.Write([uint16]1)
    $writer.Write([uint16]32)
    $writer.Write([uint32]$pngs[$i].Length)
    $writer.Write([uint32]$offset)
    $offset += $pngs[$i].Length
}
foreach ($png in $pngs) { $writer.Write($png) }
$writer.Flush()
[System.IO.File]::WriteAllBytes((Join-Path $root 'src\ZipfLaw.Wpf\Assets\zipfomancy.ico'), $ico.ToArray())
