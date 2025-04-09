using Xunit;
using FluentAssertions;

namespace PalindromeChecker.Tests;

public class PalindromeCheckerTests
{
    private readonly PalindromeChecker palindromeChecker = new();

    [Fact]
    public void PalindromeChecker_returns_true_for_empty_string()
    {
        var result = palindromeChecker.IsPalindrome(string.Empty);
        result.Should().BeTrue();
    }

    [Fact]
    public void PalindromeChecker_returns_true_for_null()
    {
        var result = palindromeChecker.IsPalindrome(null!);
        result.Should().BeTrue();
    }

    [Fact]
    public void PalindromeChecker_returns_true_for_input_ABBA()
    {
        var result = palindromeChecker.IsPalindrome("ABBA");
        result.Should().BeTrue();
    }

    [Fact]
    public void PalindromeChecker_returns_true_for_input_tattarrattat()
    {
        var result = palindromeChecker.IsPalindrome("tattarrattat");
        result.Should().BeTrue();
    }

    [Fact]
    public void PalindromeChecker_returns_false_for_input_ABCD()
    {
        var result = palindromeChecker.IsPalindrome("ABCD");
        result.Should().BeFalse();
    }

    [Fact]
    public void PalindromeChecker_returns_false_for_input_palindrome()
    {
        var result = palindromeChecker.IsPalindrome("palindrome");
        result.Should().BeFalse();
    }
}