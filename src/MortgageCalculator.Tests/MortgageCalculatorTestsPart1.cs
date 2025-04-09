using Xunit;
using FluentAssertions;

namespace MortgageCalculator.Tests;

public class MortgageCalculatorTestsPart1
{
    private readonly MortgageCalculator mortgageCalculator = new();

    [Fact]
    public void MortgageCalculator_CalculatePurchasePrice_1()
    {
        var result = mortgageCalculator.CalculatePurchasePrice(1, 1, 1, 1);
        result.Should().Be(12.95m);
    }
}