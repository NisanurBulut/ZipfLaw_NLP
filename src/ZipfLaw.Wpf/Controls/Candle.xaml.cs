using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace ZipfLaw.Wpf.Controls;

public partial class Candle : UserControl
{
    /// <summary>Seconds for one float up and down; give every candle another value so they do not move together.</summary>
    public double Seconds { get; set; } = 4;

    public Candle()
    {
        InitializeComponent();
        Loaded += (_, _) => Bob.BeginAnimation(System.Windows.Media.TranslateTransform.YProperty, new DoubleAnimation
        {
            From = -10,
            To = 10,
            Duration = TimeSpan.FromSeconds(Seconds),
            AutoReverse = true,
            RepeatBehavior = RepeatBehavior.Forever,
            EasingFunction = new SineEase { EasingMode = EasingMode.EaseInOut },
        });
    }
}
