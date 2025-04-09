using Xunit;
using FluentAssertions;

namespace PigLatin.Tests;

public class PigLatinTestsPart1
{
    private readonly PigLatin pigLatin = new();

    [Fact]
    public void PigLatin_returns_ellohay_for_input_hello()
    {
        var result = pigLatin.EnglishToPigLatin("hello");
        result.Should().Be("ellohay");
    }

    [Fact]
    public void PigLatin_returns_iway_for_input_i()
    {
        var result = pigLatin.EnglishToPigLatin("i");
        result.Should().Be("iway");
    }

    [Fact]
    public void PigLatin_returns_oveglay_for_input_glove()
    {
        var result = pigLatin.EnglishToPigLatin("glove");
        result.Should().Be("oveglay");
    }

    [Fact]
    public void PigLatin_returns_EthayIckquayOwnbrayOxfayOverwayEthayAzylayOgday_for_input_TheQuickBrownFoxJumpsOverTheLazyDog()
    {
        var result = pigLatin.EnglishToPigLatin("The quick, brown fox jumps over the lazy dog.");
        result.Should().Be("Ethay ickquay, ownbray oxfay umpsjay overway ethay azylay ogday.");
    }

    [Fact]
    public void PigLatin_returns_OdecayAtaskaArewayAwayOodgayAywayOtayOnehayOuryayIllsskay_for_input_CodeKatasAreAGoodWayToHoneYourSkills()
    {
        var result = pigLatin.EnglishToPigLatin("Code Katas are a good way to hone your skills.");
        result.Should().Be("Odecay Ataskay areway away oodgay ayway otay onehay ouryay illsskay.");
    }
}