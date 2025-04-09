using FluentAssertions;
using Xunit;

namespace CaesarCipher.Tests;

public class CaesarCipherTestsPart2
{
    private readonly CaesarCipher caesarCipher = new();

    [Fact]
    public void CaesarCipher_decodes_hello_world_with_4_shift()
    {
        var result = caesarCipher.Encode("Lipps, Asvph!", 4);
        
        result.Should().Be("Hello, World!");
    }

    [Fact]
    public void CaesarCipher_dncode_does_not_alter_numbers()
    {
        var result = caesarCipher.Encode("BCD123", 1);
        
        result.Should().Be("ABC123");
    }
}