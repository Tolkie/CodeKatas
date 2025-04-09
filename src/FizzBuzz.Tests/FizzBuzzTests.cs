using Xunit;
using FluentAssertions;

namespace FizzBuzz.Tests;

public class FizzBuzzTests
{
    private readonly FizzBuzz fizzBuzz = new();

    [Fact]
    public void FizzBuzz_returns_1_for_input_1()
    {
        var result = fizzBuzz.Check(1);
        result.Should().Be("1");
    }

    [Fact]
    public void FizzBuzz_returns_Fizz_for_input_3()
    {
        var result = fizzBuzz.Check(3);
        result.Should().Be("Fizz");
    }

    [Fact]
    public void FizzBuzz_returns_Buzz_for_input_5()
    {
        var result = fizzBuzz.Check(5);
        result.Should().Be("Buzz");
    }

    [Fact]
    public void FizzBuzz_returns_Fizz_for_input_6()
    {
        var result = fizzBuzz.Check(6);
        result.Should().Be("Fizz");
    }

    [Fact]
    public void FizzBuzz_returns_Buzz_for_input_10()
    {
        var result = fizzBuzz.Check(10);
        result.Should().Be("Buzz");
    }

    [Fact]
    public void FizzBuzz_returns_FizzBuzz_for_input_15()
    {
        var result = fizzBuzz.Check(15);
        result.Should().Be("FizzBuzz");
    }

    [Fact]
    public void FizzBuzz_returns_FizzBuzz_for_input_30()
    {
        var result = fizzBuzz.Check(30);
        result.Should().Be("FizzBuzz");
    }

    [Fact]
    public void FizzBuzz_returns_64_for_input_64()
    {
        var result = fizzBuzz.Check(64);
        result.Should().Be("64");
    }
}