using ZipfLaw.Core;

namespace ZipfLaw.Core.Tests;

public class ZipfAnalyzerTests
{
    [Fact]
    public void Counts_words_and_ranks_the_most_frequent_first()
    {
        var result = ZipfAnalyzer.Analyze("the cat and the dog and the bird", TextLanguage.English);

        Assert.Equal(8, result.TotalWords);
        Assert.Equal(5, result.UniqueWords);
        Assert.Equal(["the", "and", "bird", "cat", "dog"], result.Words.Select(w => w.Word));
        Assert.Equal([3, 2, 1, 1, 1], result.Words.Select(w => w.Count));
        Assert.Equal([1, 2, 3, 4, 5], result.Words.Select(w => w.Rank));
    }

    [Fact]
    public void Computes_zipf_constants()
    {
        var result = ZipfAnalyzer.Analyze("a a a a b b c d", TextLanguage.English);

        var second = result.Words[1];
        Assert.Equal("b", second.Word);
        Assert.Equal(2 * 2, second.RankTimesCount);
        Assert.Equal(2 * (2.0 / 8), second.RankTimesProbability, 6);
    }

    [Fact]
    public void Ignores_case_punctuation_and_digits()
    {
        var result = ZipfAnalyzer.Analyze("Harry, harry! HARRY? 42 (Ron)", TextLanguage.English);

        Assert.Equal(4, result.TotalWords);
        Assert.Equal("harry", result.Words[0].Word);
        Assert.Equal(3, result.Words[0].Count);
    }

    [Fact]
    public void Keeps_english_contractions_together()
    {
        var result = ZipfAnalyzer.Analyze("don't don't can't", TextLanguage.English);

        Assert.Equal("don't", result.Words[0].Word);
        Assert.Equal(2, result.Words[0].Count);
    }

    [Fact]
    public void Turkish_lower_casing_follows_the_dotted_and_dotless_i()
    {
        var result = ZipfAnalyzer.Analyze("Işık ışık İnsan insan", TextLanguage.Turkish);

        Assert.Equal(["insan", "ışık"], result.Words.Select(w => w.Word));
        Assert.All(result.Words, w => Assert.Equal(2, w.Count));
    }

    [Fact]
    public void Turkish_drops_the_suffix_after_an_apostrophe()
    {
        var result = ZipfAnalyzer.Analyze("Harry'nin Harry'ye Harry", TextLanguage.Turkish);

        Assert.Single(result.Words);
        Assert.Equal("harry", result.Words[0].Word);
        Assert.Equal(3, result.Words[0].Count);
    }

    [Fact]
    public void Empty_text_gives_an_empty_result()
    {
        var result = ZipfAnalyzer.Analyze("  ... 123 ", TextLanguage.English);

        Assert.Equal(0, result.TotalWords);
        Assert.Empty(result.Words);
    }
}
