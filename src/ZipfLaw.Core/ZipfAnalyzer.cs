using System.Globalization;
using System.Text.RegularExpressions;

namespace ZipfLaw.Core;

public enum TextLanguage
{
    English,
    Turkish,
}

/// <summary>One row of the Zipf table: a word, its rank and how often it occurs.</summary>
/// <param name="Rank">1 for the most frequent word, 2 for the next one, ...</param>
/// <param name="Probability">Count divided by the total number of words in the text.</param>
public sealed record WordStat(int Rank, string Word, int Count, double Probability)
{
    /// <summary>Zipf's law: rank × count stays roughly constant.</summary>
    public double RankTimesCount => Rank * (double)Count;

    /// <summary>Zipf's law: rank × probability stays roughly constant (about 0.1 for English).</summary>
    public double RankTimesProbability => Rank * Probability;
}

/// <summary>Words of a text, most frequent first.</summary>
public sealed record ZipfResult(int TotalWords, IReadOnlyList<WordStat> Words)
{
    public int UniqueWords => Words.Count;
}

public static partial class ZipfAnalyzer
{
    // Letters, with an apostrophe allowed inside a word: don't, Harry's, Harry'nin.
    [GeneratedRegex(@"\p{L}+(?:['’]\p{L}+)*")]
    private static partial Regex WordPattern();

    public static ZipfResult Analyze(string text, TextLanguage language)
    {
        var culture = language == TextLanguage.Turkish ? new CultureInfo("tr-TR") : CultureInfo.InvariantCulture;

        var words = WordPattern().Matches(text).Select(match => Normalize(match.Value, language, culture)).ToList();

        var ranked = words
            .GroupBy(word => word)
            .OrderByDescending(group => group.Count())
            .ThenBy(group => group.Key, StringComparer.Ordinal)
            .Select((group, index) => new WordStat(index + 1, group.Key, group.Count(), (double)group.Count() / words.Count))
            .ToList();

        return new ZipfResult(words.Count, ranked);
    }

    // Lower-cases with the right culture (Turkish I/İ/ı) and, in Turkish, drops the suffix after an apostrophe:
    // "Harry'nin" counts as "harry".
    private static string Normalize(string word, TextLanguage language, CultureInfo culture)
    {
        if (language == TextLanguage.Turkish)
        {
            word = word.Split('\'', '’')[0];
        }
        return word.ToLower(culture);
    }
}
