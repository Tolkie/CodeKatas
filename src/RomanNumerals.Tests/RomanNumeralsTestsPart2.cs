using Xunit;
using FluentAssertions;

namespace RomanNumerals.Tests;

public class RomanNumeralsTestsPart2
{
    private readonly RomanNumerals romanNumerals = new();

    [Fact]
    public void RomanNumerals_returns_1_for_input_I()
    {
        var result = romanNumerals.RomanNumeralToArabic("I");
        result.Should().Be(1);
    }

    [Fact]
    public void RomanNumerals_returns_4_for_input_IV()
    {
        var result = romanNumerals.RomanNumeralToArabic("IV");
        result.Should().Be(4);
    }

    [Fact]
    public void RomanNumerals_returns_5_for_input_V()
    {
        var result = romanNumerals.RomanNumeralToArabic("V");
        result.Should().Be(5);
    }

    [Fact]
    public void RomanNumerals_returns_6_for_input_VI()
    {
        var result = romanNumerals.RomanNumeralToArabic("VI");
        result.Should().Be(6);
    }

    [Fact]
    public void RomanNumerals_returns_9_for_input_IX()
    {
        var result = romanNumerals.RomanNumeralToArabic("IX");
        result.Should().Be(9);
    }

    [Fact]
    public void RomanNumerals_returns_10_for_input_X()
    {
        var result = romanNumerals.RomanNumeralToArabic("X");
        result.Should().Be(10);
    }

    [Fact]
    public void RomanNumerals_returns_11_for_input_XI()
    {
        var result = romanNumerals.RomanNumeralToArabic("XI");
        result.Should().Be(11);
    }

    [Fact]
    public void RomanNumerals_returns_50_for_input_L()
    {
        var result = romanNumerals.RomanNumeralToArabic("L");
        result.Should().Be(50);
    }

    [Fact]
    public void RomanNumerals_returns_100_for_input_C()
    {
        var result = romanNumerals.RomanNumeralToArabic("C");
        result.Should().Be(100);
    }

    [Fact]
    public void RomanNumerals_returns_500_for_input_D()
    {
        var result = romanNumerals.RomanNumeralToArabic("D");
        result.Should().Be(500);
    }

    [Fact]
    public void RomanNumerals_returns_1000_for_input_M()
    {
        var result = romanNumerals.RomanNumeralToArabic("M");
        result.Should().Be(1000);
    }

    [Fact]
    public void RomanNumerals_returns_1999_for_input_MCMXCIX()
    {
        var result = romanNumerals.RomanNumeralToArabic("MCMXCIX");
        result.Should().Be(1999);
    }

    [Fact]
    public void RomanNumerals_returns_4999_for_input_MMMMCMXCIX()
    {
        var result = romanNumerals.RomanNumeralToArabic("MMMMCMXCIX");
        result.Should().Be(4999);
    }
}