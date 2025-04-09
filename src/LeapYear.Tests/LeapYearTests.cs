using Xunit;
using FluentAssertions;

namespace LeapYear.Tests;

public class LeapYearTests
{
    private readonly LeapYear leapYear = new();

    [Fact]
    public void LeapYear_returns_true_for_1904()
    {
        var result = leapYear.IsLeapYear(1904);
        result.Should().BeTrue();
    }

    [Fact]
    public void LeapYear_returns_true_for_1952()
    {
        var result = leapYear.IsLeapYear(1952);
        result.Should().BeTrue();
    }

    [Fact]
    public void LeapYear_returns_true_for_2000()
    {
        var result = leapYear.IsLeapYear(2000);
        result.Should().BeTrue();
    }

    [Fact]
    public void LeapYear_returns_true_for_2012()
    {
        var result = leapYear.IsLeapYear(2012);
        result.Should().BeTrue();
    }

    [Fact]
    public void LeapYear_returns_true_for_2048()
    {
        var result = leapYear.IsLeapYear(2048);
        result.Should().BeTrue();
    }

    [Fact]
    public void LeapYear_returns_true_for_2096()
    {
        var result = leapYear.IsLeapYear(2096);
        result.Should().BeTrue();
    }

    [Fact]
    public void LeapYear_returns_false_for_1700()
    {
        var result = leapYear.IsLeapYear(1700);
        result.Should().BeFalse();
    }

    [Fact]
    public void LeapYear_returns_false_for_1900()
    {
        var result = leapYear.IsLeapYear(1900);
        result.Should().BeFalse();
    }

    [Fact]
    public void LeapYear_returns_false_for_2100()
    {
        var result = leapYear.IsLeapYear(2100);
        result.Should().BeFalse();
    }

    [Fact]
    public void LeapYear_returns_false_for_2001()
    {
        var result = leapYear.IsLeapYear(2001);
        result.Should().BeFalse();
    }

    [Fact]
    public void LeapYear_returns_false_for_2014()
    {
        var result = leapYear.IsLeapYear(2014);
        result.Should().BeFalse();
    }

    [Fact]
    public void LeapYear_returns_false_for_2050()
    {
        var result = leapYear.IsLeapYear(2050);
        result.Should().BeFalse();
    }
    
    [Fact]
    public void LeapYear_returns_false_for_4AD()
    {
        var result = leapYear.IsLeapYear(4);
        result.Should().BeFalse();
    }

    [Fact]
    public void LeapYear_returns_false_for_0AD()
    {
        var result = leapYear.IsLeapYear(0);
        result.Should().BeFalse();
    }

    [Fact]
    public void LeapYear_returns_false_for_50BC()
    {
        var result = leapYear.IsLeapYear(-50);
        result.Should().BeFalse();
    }

    [Fact]
    public void LeapYear_returns_true_for_8AD()
    {
        var result = leapYear.IsLeapYear(8);
        result.Should().BeTrue();
    }

    [Fact]
    public void LeapYear_returns_true_for_30BC()
    {
        var result = leapYear.IsLeapYear(-30);
        result.Should().BeTrue();
    }

    [Fact]
    public void LeapYear_returns_true_for_45BC()
    {
        var result = leapYear.IsLeapYear(-45);
        result.Should().BeTrue();
    }
}