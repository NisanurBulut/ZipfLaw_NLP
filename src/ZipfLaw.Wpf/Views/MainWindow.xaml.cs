using System.Windows;
using Microsoft.Win32;
using ZipfLaw.Wpf.ViewModels;

namespace ZipfLaw.Wpf.Views;

public partial class MainWindow : Window
{
    private readonly MainViewModel _viewModel = new();

    public MainWindow()
    {
        InitializeComponent();
        DataContext = _viewModel;

        // Start with the first book so there is something to see right away.
        Loaded += (_, _) => _viewModel.AnalyzeCommand.Execute(null);
    }

    private void OnBrowseClick(object sender, RoutedEventArgs e)
    {
        var dialog = new OpenFileDialog { Filter = "Metin dosyaları (*.txt)|*.txt" };
        if (dialog.ShowDialog(this) == true)
        {
            _viewModel.AddBook(dialog.FileName);
        }
    }
}
