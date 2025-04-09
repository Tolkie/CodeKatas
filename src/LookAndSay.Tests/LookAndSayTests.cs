using Xunit;
using FluentAssertions;

namespace LookAndSay.Tests;

public class LookAndSayTests
{
    private readonly LookAndSay lookAndSay = new();

    [Fact]
    public void LookAndSay_returns_empty_string_for_input_empty_string()
    {
        var result = lookAndSay.CalculateNextSequence(string.Empty);
        result.Should().Be(string.Empty);
    }

    [Fact]
    public void LookAndSay_returns_11_for_input_1()
    {
        var result = lookAndSay.CalculateNextSequence("1");
        result.Should().Be("11");
    }

    [Fact]
    public void LookAndSay_returns_311221_for_input_111211()
    {
        var result = lookAndSay.CalculateNextSequence("111211");
        result.Should().Be("311221");
    }

    [Fact]
    public void LookAndSay_returns_11121314151617181910_for_input_1234567890()
    {
        var result = lookAndSay.CalculateNextSequence("1234567890");
        result.Should().Be("11121314151617181910");
    }

    [Fact]
    public void LookAndSay_returns_101_for_input_1111111111()
    {
        var result = lookAndSay.CalculateNextSequence("1111111111");
        result.Should().Be("101");
    }

    [Fact]
    public void LookAndSay_throws_ArgumentException_exception_if_sequence_has_non_numeric_characters()
    {
        Action act = () => lookAndSay.CalculateNextSequence("ABC");
        act.Should().Throw<ArgumentException>();
    }
}