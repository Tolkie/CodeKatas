
using FluentAssertions;
using Xunit;

namespace BinaryNumbers.Tests;

public class BinaryNumbersTestsPart2
{
    private readonly BinaryNumbers binaryNumbers = new();

    [Fact]
    public void BinaryNumbers_returns_0_for_input_00000000000000000000000000000000()
    {
        var result = binaryNumbers.BinaryToInteger("0000000000000000000000000000000");
        result.Should().Be(0);
    }

    [Fact]
    public void BinaryNumbers_returns_1_for_input_00000000000000000000000000000001()
    {
        var result = binaryNumbers.BinaryToInteger("0000000000000000000000000000001");
        result.Should().Be(1);
    }

    [Fact]
    public void BinaryNumbers_returns_1024_for_input_0000000000000000000010000000000()
    {
        var result = binaryNumbers.BinaryToInteger("0000000000000000000010000000000");
        result.Should().Be(1024);
    }

    [Fact]
    public void BinaryNumbers_returns_65535_for_input_00000000000000001111111111111111()
    {
        var result = binaryNumbers.BinaryToInteger("0000000000000001111111111111111");
        result.Should().Be(65535);
    }

    [Fact]
    public void BinaryNumbers_returns_10485760_for_input_000000000010000000000000000000()
    {
        var result = binaryNumbers.BinaryToInteger("0000000000100000000000000000000");
        result.Should().Be(1048576);
    }

    [Fact]
    public void BinaryNumbers_returns_1431655765_for_input_01010101010101010101010101010101()
    {
        var result = binaryNumbers.BinaryToInteger("10101010101010101010101010101010");
        result.Should().Be(1431655765);
    }

    [Fact]
    public void BinaryNumbers_returns_2147483647_for_input_01111111111111111111111111111111()
    {
        var result = binaryNumbers.BinaryToInteger("01111111111111111111111111111111");
        result.Should().Be(2147483647);
    }
}