using Xunit;
using FluentAssertions;

namespace PrimeNumbers.Tests;

public class PrimeNumbersTests
{
    private readonly PrimeNumbers primeNumbers = new();

    [Fact]
    public void TestMethod1()
    {
        var result = primeNumbers.GetNextPrimeNumber(1);
        result.Should().Be(0);
    }
}