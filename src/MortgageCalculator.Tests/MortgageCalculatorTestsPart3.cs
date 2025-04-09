using Xunit;
using FluentAssertions;

namespace MortgageCalculator.Tests;

public class MortgageCalculatorTestsPart3
{
    private readonly MortgageCalculator mortgageCalculator = new();

    [Fact]
    public void MortgageCalculator_CalculateDownPayment_1()
    {
        var result = mortgageCalculator.CalculateDownPayment(1, 0, 12, 1);
        result.Should().Be(0);
    }
}