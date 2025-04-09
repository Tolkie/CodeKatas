using Xunit;
using FluentAssertions;

namespace RomanNumerals.Tests;

public class RomanNumeralsTestsPart1
{
    private readonly RomanNumerals romanNumerals = new();

    [Fact]
    public void RomanNumerals_returns_empty_string_for_input_0()
    {
        var result = romanNumerals.ArabicToRomanNumeral(0);
        result.Should().BeEmpty();
    }

    [Fact]
    public void RomanNumerals_returns_I_for_input_1()
    {
        var result = romanNumerals.ArabicToRomanNumeral(1);
        result.Should().Be("I");
    }

    [Fact]
    public void RomanNumerals_returns_IV_for_input_4()
    {
        var result = romanNumerals.ArabicToRomanNumeral(4);
        result.Should().Be("IV");
    }

    [Fact]
    public void RomanNumerals_returns_V_for_input_5()
    {
        var result = romanNumerals.ArabicToRomanNumeral(5);
        result.Should().Be("V");
    }

    [Fact]
    public void RomanNumerals_returns_VI_for_input_6()
    {
        var result = romanNumerals.ArabicToRomanNumeral(6);
        result.Should().Be("VI");
    }

    [Fact]
    public void RomanNumerals_returns_I_for_input_9()
    {
        var result = romanNumerals.ArabicToRomanNumeral(9);
        result.Should().Be("IX");
    }

    [Fact]
    public void RomanNumerals_returns_I_for_input_10()
    {
        var result = romanNumerals.ArabicToRomanNumeral(10);
        result.Should().Be("X");
    }

    [Fact]
    public void RomanNumerals_returns_I_for_input_11()
    {
        var result = romanNumerals.ArabicToRomanNumeral(11);
        result.Should().Be("XI");
    }

    [Fact]
    public void RomanNumerals_returns_L_for_input_50()
    {
        var result = romanNumerals.ArabicToRomanNumeral(50);
        result.Should().Be("L");
    }

    [Fact]
    public void RomanNumerals_returns_C_for_input_100()
    {
        var result = romanNumerals.ArabicToRomanNumeral(100);
        result.Should().Be("C");
    }

    [Fact]
    public void RomanNumerals_returns_D_for_input_500()
    {
        var result = romanNumerals.ArabicToRomanNumeral(500);
        result.Should().Be("D");
    }

    [Fact]
    public void RomanNumerals_returns_M_for_input_1000()
    {
        var result = romanNumerals.ArabicToRomanNumeral(1000);
        result.Should().Be("M");
    }

    [Fact]
    public void RomanNumerals_returns_MCMXCIX_for_input_1999()
    {
        var result = romanNumerals.ArabicToRomanNumeral(1999);
        result.Should().Be("MCMXCIX");
    }

    [Fact]
    public void RomanNumerals_returns_MMMMCMXCIX_for_input_4999()
    {
        var result = romanNumerals.ArabicToRomanNumeral(4999);
        result.Should().Be("MMMMCMXCIX");
    }
}