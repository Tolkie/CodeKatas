using Xunit;
using FluentAssertions;

namespace IncomeTax.Tests;

public class IncomeTaxTests
{
    private readonly IncomeTax incomeTax = new();

    [Fact]
    public void No_Income_Returns_0()
    {
        var result = incomeTax.CalculateTax(0);
        result.Should().Be(0);
    }

    [Fact]
    public void Negative_Income_Returns_0()
    {
        var result = incomeTax.CalculateTax(-1);
        result.Should().Be(0);
    }

    [Fact]
    public void Income_Of_10000_Returns_1085()
    {
        var result = incomeTax.CalculateTax(10000);
        result.Should().Be(1085);
    }

    [Fact]
    public void Income_Of_20000_Returns_2554()
    {
        var result = incomeTax.CalculateTax(20000);
        result.Should().Be(2554);
    }

    [Fact]
    public void Income_Of_450000_Returns_135964()
    {
        var result = incomeTax.CalculateTax(450000);
        result.Should().Be(135964);
    }
}