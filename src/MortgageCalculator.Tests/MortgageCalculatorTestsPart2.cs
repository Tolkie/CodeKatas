using Xunit;
using FluentAssertions;

namespace MortgageCalculator.Tests;

public class MortgageCalculatorTestsPart2
{
    private readonly MortgageCalculator mortgageCalculator = new();

    [Fact]
    public void MortgageCalculator_CalculateMonthlyPayment_1()
    {
        var result = mortgageCalculator.CalculateMonthlyPayment(1, 0, 12, 0);
        result.Should().Be(1);
    }
}