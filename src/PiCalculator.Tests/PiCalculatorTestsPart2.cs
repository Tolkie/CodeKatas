using Xunit;
using FluentAssertions;

namespace PiCalculator.Tests;

public class PiCalculatorTestsPart2
{
    private readonly PiCalculator piCalculator = new();

    [Fact]
    public void PiCalculator_GetPiDigit_returns_1_for_input_1()
    {
        var result = piCalculator.GetPiDigit(1);
        result.Should().Be(1);
    }
}