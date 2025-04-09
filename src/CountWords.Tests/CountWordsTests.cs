using FluentAssertions;
using Xunit;

namespace CountWords.Tests;

public class CountWordsTests
{
    private readonly CountWords countWords = new();
    
    [Fact]
    public void CountWords_returns_0_for_empty_string()
    {
        var result = countWords.Count(string.Empty);
        result.Should().Be(0);
    }

    [Fact]
    public void CountWords_returns_2_for_HelloWorld()
    {
        var result = countWords.Count("Hello, World!");
        result.Should().Be(2);
    }

    [Fact]
    public void CountWords_returns_4_for_comma_seperated_list_with_no_spaces()
    {
        var result = countWords.Count("Billy,Bob,Joe,Jim");
        result.Should().Be(4);
    }
}