using System.Globalization;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Animation;
using ZipfLaw.Core;

namespace ZipfLaw.Wpf.Controls;

/// <summary>
/// The classic Zipf plot: rank on the x axis and count on the y axis, both logarithmic.
/// A text that follows Zipf's law lies close to the straight line with slope -1; the dots are drawn in as a short animation.
/// </summary>
public sealed class ZipfPlot : FrameworkElement
{
    private const double LeftMargin = 96;
    private const double TopMargin = 16;
    private const double RightMargin = 40;
    private const double BottomMargin = 46;
    private static readonly Typeface LabelFont = new("Palatino Linotype");

    public static readonly DependencyProperty WordsProperty = DependencyProperty.Register(
        nameof(Words), typeof(IReadOnlyList<WordStat>), typeof(ZipfPlot),
        new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender, OnWordsChanged));

    public static readonly DependencyProperty LineBrushProperty = Register(nameof(LineBrush));
    public static readonly DependencyProperty IdealBrushProperty = Register(nameof(IdealBrush));
    public static readonly DependencyProperty AxisBrushProperty = Register(nameof(AxisBrush));

    // 0..1: how much of the curve is drawn so far.
    private static readonly DependencyProperty ProgressProperty = DependencyProperty.Register(
        "Progress", typeof(double), typeof(ZipfPlot), new FrameworkPropertyMetadata(1.0, FrameworkPropertyMetadataOptions.AffectsRender));

    public IReadOnlyList<WordStat>? Words { get => (IReadOnlyList<WordStat>?)GetValue(WordsProperty); set => SetValue(WordsProperty, value); }
    public Brush? LineBrush { get => (Brush?)GetValue(LineBrushProperty); set => SetValue(LineBrushProperty, value); }
    public Brush? IdealBrush { get => (Brush?)GetValue(IdealBrushProperty); set => SetValue(IdealBrushProperty, value); }
    public Brush? AxisBrush { get => (Brush?)GetValue(AxisBrushProperty); set => SetValue(AxisBrushProperty, value); }

    public ZipfPlot() => ClipToBounds = true;

    private static DependencyProperty Register(string name) =>
        DependencyProperty.Register(name, typeof(Brush), typeof(ZipfPlot),
            new FrameworkPropertyMetadata(null, FrameworkPropertyMetadataOptions.AffectsRender));

    private static void OnWordsChanged(DependencyObject d, DependencyPropertyChangedEventArgs e) =>
        ((ZipfPlot)d).BeginAnimation(ProgressProperty, new DoubleAnimation(0, 1, TimeSpan.FromSeconds(1.6))
        {
            EasingFunction = new QuadraticEase { EasingMode = EasingMode.EaseOut },
        });

    protected override void OnRender(DrawingContext dc)
    {
        var plot = new Rect(LeftMargin, TopMargin, ActualWidth - LeftMargin - RightMargin, ActualHeight - TopMargin - BottomMargin);
        if (Words is not { Count: > 1 } words || plot.Width <= 0 || plot.Height <= 0)
        {
            return;
        }

        // Axes run over whole powers of ten: 1, 10, 100, ...
        var xDecades = Math.Max(1, (int)Math.Ceiling(Math.Log10(words.Count)));
        var yDecades = Math.Max(1, (int)Math.Ceiling(Math.Log10(words[0].Count)));
        double X(double logRank) => plot.Left + logRank / xDecades * plot.Width;
        double Y(double logCount) => plot.Bottom - logCount / yDecades * plot.Height;

        DrawGrid(dc, plot, xDecades, yDecades, X, Y);

        dc.PushClip(new RectangleGeometry(plot));

        // Zipf's ideal: count = count of the first word / rank, a straight line with slope -1 on a log-log plot.
        var firstCount = Math.Log10(words[0].Count);
        dc.DrawLine(new Pen(IdealBrush, 2) { DashStyle = DashStyles.Dash }, new Point(X(0), Y(firstCount)), new Point(X(xDecades), Y(firstCount - xDecades)));

        var drawn = Math.Max(2, (int)(words.Count * (double)GetValue(ProgressProperty)));
        var curve = new StreamGeometry();
        using (var context = curve.Open())
        {
            context.BeginFigure(PointOf(words[0]), false, false);
            for (var i = 1; i < drawn; i++)
            {
                context.LineTo(PointOf(words[i]), true, true);
            }
        }
        curve.Freeze();
        dc.DrawGeometry(null, new Pen(LineBrush, 2.4) { LineJoin = PenLineJoin.Round }, curve);
        dc.DrawEllipse(LineBrush, null, PointOf(words[drawn - 1]), 5, 5);

        dc.Pop();
        DrawLabels(dc, plot);

        Point PointOf(WordStat word) => new(X(Math.Log10(word.Rank)), Y(Math.Log10(word.Count)));
    }

    private void DrawGrid(DrawingContext dc, Rect plot, int xDecades, int yDecades, Func<double, double> x, Func<double, double> y)
    {
        var gridPen = new Pen(AxisBrush, 1);
        dc.PushOpacity(0.25);
        for (var d = 0; d <= xDecades; d++)
        {
            dc.DrawLine(gridPen, new Point(x(d), plot.Top), new Point(x(d), plot.Bottom));
        }
        for (var d = 0; d <= yDecades; d++)
        {
            dc.DrawLine(gridPen, new Point(plot.Left, y(d)), new Point(plot.Right, y(d)));
        }
        dc.Pop();

        for (var d = 0; d <= xDecades; d++)
        {
            DrawText(dc, Math.Pow(10, d).ToString("N0"), new Point(x(d), plot.Bottom + 14), 12, 0.5);
        }
        for (var d = 0; d <= yDecades; d++)
        {
            DrawText(dc, Math.Pow(10, d).ToString("N0"), new Point(plot.Left - 8, y(d)), 12, 1);
        }
    }

    private void DrawLabels(DrawingContext dc, Rect plot)
    {
        DrawText(dc, "sıra (logaritmik)", new Point(plot.Left + plot.Width / 2, plot.Bottom + 36), 13, 0.5);

        var middle = plot.Top + plot.Height / 2;
        dc.PushTransform(new RotateTransform(-90, 14, middle));
        DrawText(dc, "kullanım sayısı (logaritmik)", new Point(14, middle), 13, 0.5);
        dc.Pop();

        var legend = new Point(plot.Right - 190, plot.Top + 16);
        dc.DrawLine(new Pen(LineBrush, 2.4), legend, legend + new Vector(28, 0));
        DrawText(dc, "metindeki kelimeler", legend + new Vector(36, 0), 12, 0);
        dc.DrawLine(new Pen(IdealBrush, 2) { DashStyle = DashStyles.Dash }, legend + new Vector(0, 22), legend + new Vector(28, 22));
        DrawText(dc, "Zipf: sayı ∝ 1 / sıra", legend + new Vector(36, 22), 12, 0);
    }

    /// <summary>Draws text centred vertically on the anchor; align is 0 (starts at the anchor), 0.5 (centred) or 1 (ends at the anchor).</summary>
    private void DrawText(DrawingContext dc, string text, Point anchor, double size, double align)
    {
        var formatted = new FormattedText(text, CultureInfo.CurrentCulture, FlowDirection.LeftToRight, LabelFont, size, AxisBrush,
            VisualTreeHelper.GetDpi(this).PixelsPerDip);
        dc.DrawText(formatted, new Point(anchor.X - formatted.Width * align, anchor.Y - formatted.Height / 2));
    }
}
