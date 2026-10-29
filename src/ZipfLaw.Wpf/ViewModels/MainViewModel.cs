using System.Collections.ObjectModel;
using System.IO;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ZipfLaw.Core;

namespace ZipfLaw.Wpf.ViewModels;

public sealed record Book(string Title, string Path, TextLanguage Language);

public sealed record LanguageOption(TextLanguage Language, string Name);

/// <summary>One bar of the "most frequent words" chart. Ratio is the count relative to the most frequent word (0..1).</summary>
public sealed record BarRow(int Rank, string Word, int Count, double Ratio);

public sealed partial class MainViewModel : ObservableObject
{
    private const int BarCount = 15;
    private const int AverageOverWords = 100;

    public ObservableCollection<Book> Books { get; } =
    [
        new("Harry Potter ve Felsefe Taşı (Türkçe)", BookPath("HarryPotterKitap1Tr.txt"), TextLanguage.Turkish),
        new("Harry Potter and the Sorcerer's Stone (English)", BookPath("HarryPotterBook1En.txt"), TextLanguage.English),
    ];

    public IReadOnlyList<LanguageOption> Languages { get; } =
    [
        new(TextLanguage.English, "English"),
        new(TextLanguage.Turkish, "Türkçe"),
    ];

    [ObservableProperty]
    public partial Book SelectedBook { get; set; }

    [ObservableProperty]
    public partial TextLanguage Language { get; set; }

    [ObservableProperty]
    [NotifyCanExecuteChangedFor(nameof(AnalyzeCommand))]
    public partial bool IsBusy { get; private set; }

    [ObservableProperty]
    public partial string Status { get; private set; } = "Bir metin seç ve büyüyü başlat.";

    [ObservableProperty]
    public partial ZipfResult? Result { get; private set; }

    [ObservableProperty]
    public partial IReadOnlyList<BarRow> TopWords { get; private set; } = [];

    /// <summary>Average of rank × probability over the first words: Zipf says this is roughly constant.</summary>
    [ObservableProperty]
    public partial double AverageA { get; private set; }

    public MainViewModel()
    {
        SelectedBook = Books[0];
        Language = SelectedBook.Language;
    }

    partial void OnSelectedBookChanged(Book value) => Language = value.Language;

    /// <summary>Adds a text file picked by the user and selects it.</summary>
    public void AddBook(string path)
    {
        var book = new Book(System.IO.Path.GetFileNameWithoutExtension(path), path, Language);
        Books.Add(book);
        SelectedBook = book;
    }

    [RelayCommand(CanExecute = nameof(CanAnalyze))]
    private async Task AnalyzeAsync()
    {
        IsBusy = true;
        Status = "Büyü hazırlanıyor…";
        try
        {
            var text = await File.ReadAllTextAsync(SelectedBook.Path);
            var result = await Task.Run(() => ZipfAnalyzer.Analyze(text, Language));
            Show(result);
            Status = $"{SelectedBook.Title}: {result.TotalWords:N0} kelime çözümlendi.";
        }
        catch (Exception ex) when (ex is IOException or UnauthorizedAccessException)
        {
            Status = $"Dosya okunamadı: {ex.Message}";
        }
        finally
        {
            IsBusy = false;
        }
    }

    private bool CanAnalyze() => !IsBusy;

    private void Show(ZipfResult result)
    {
        Result = result;
        AverageA = result.Words.Take(AverageOverWords).Select(word => word.RankTimesProbability).DefaultIfEmpty().Average();
        TopWords = result.Words
            .Take(BarCount)
            .Select(word => new BarRow(word.Rank, word.Word, word.Count, (double)word.Count / result.Words[0].Count))
            .ToList();
    }

    private static string BookPath(string fileName) => System.IO.Path.Combine(AppContext.BaseDirectory, "Books", fileName);
}
