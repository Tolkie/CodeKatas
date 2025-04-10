using FluentAssertions;
using Xunit;

namespace CaesarCipher.Tests;

public sealed class CaesarCipherTestsPart1
{
    private readonly CaesarCipher caesarCipher = new();

    [Fact]
    public void CaesarCipher_encodes_hello_world_with_4_shift()
    {
        var result = caesarCipher.Encode("Hello, World!", 4);
        
        result.Should().Be("Lipps, Asvph!");
    }

    [Fact]
    public void CaesarCipher_encode_does_not_alter_numbers()
    {
        var result = caesarCipher.Encode("ABC123", 1);
        
        result.Should().Be("BCD123");
    }
}