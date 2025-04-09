using Xunit;
using FluentAssertions;

namespace PigLatin.Tests;

public class PigLatinTestsPart2
{
    private readonly PigLatin pigLatin = new();

    [Fact]
    public void PigLatin_returns_hello_for_input_ellohay()
    {
        var result = pigLatin.PigLatinToEnglish("ellohay");
        result.Should().Be("hello");
    }

    [Fact]
    public void PigLatin_returns_i_for_input_iway()
    {
        var result = pigLatin.PigLatinToEnglish("iway");
        result.Should().Be("i");
    }

    [Fact]
    public void PigLatin_returns_glove_for_input_oveglay()
    {
        var result = pigLatin.PigLatinToEnglish("oveglay");
        result.Should().Be("glove");
    }
    
    [Fact]
    public void PigLatin_returns_TheQuickBrownFoxJumpsOverTheLazyDog_for_input_EthayIckquayOwnbrayOxfayOverwayEthayAzylayOgday()
    {
        var result = pigLatin.PigLatinToEnglish("Ethay ickquay, ownbray oxfay umpsjay overway ethay azylay ogday.");
        result.Should().Be("The quick, brown fox jumps over the lazy dog.");
    }

    [Fact]
    public void PigLatin_returns_CodeKatasAreAGoodWayToHoneYourSkills_for_input_OdecayAtaskaArewayAwayOodgayAywayOtayOnehayOuryayIllsskay()
    {
        var result = pigLatin.PigLatinToEnglish("Odecay Ataskay areway away oodgay ayway otay onehay ouryay illsskay.");
        result.Should().Be("Code Katas are a good way to hone your skills.");
    }
}