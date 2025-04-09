using Xunit;
using FluentAssertions;

namespace ReverseString.Tests;

public class ReverseStringTests
{
    private readonly ReverseString reverseString = new();

    [Fact]
    public void ReverseString_HelloWorld()
    {
        var result = reverseString.Reverse("Hello, World!");
        result.Should().Be("!dlroW ,olleH");
    }

    [Fact]
    public void ReverseString_called_twice_returns_original_value()
    {
        const string expected = "Hello, World!";
        var result = reverseString.Reverse(reverseString.Reverse(expected));
        result.Should().Be(expected);
    }

    [Fact]
    public void ReverseString_returns_empty_string_for_input_of_empty_string()
    {
        var result = reverseString.Reverse(string.Empty);
        result.Should().Be(string.Empty);
    }
}