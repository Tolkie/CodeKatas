using FluentAssertions;
using Xunit;

namespace PiCalculator.Tests;

public class PiCalculatorTestsPart1
{
    private readonly PiCalculator piCalculator = new();

    [Fact]
    public void PiCalculator_GetPi_returns_314_for_input_2()
    {
        var result = piCalculator.GetPi(2);
        result.Should().Be("3.14");
    }
}