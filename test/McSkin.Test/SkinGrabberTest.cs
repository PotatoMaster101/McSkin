using Xunit;

namespace McSkin.Test;

/// <summary>
/// Unit tests for <see cref="SkinGrabber"/>.
/// </summary>
public class SkinGrabberTest
{
    [Theory]
    [InlineData("Resources/PotatoMaster101.png", false)]
    [InlineData("Resources/MHF_Pig.png", true)]
    public async Task FromFile_ReturnsSkin(string path, bool isLegacy)
    {
        // act
        using var skin = await SkinGrabber.FromFile(path);

        // assert
        Assert.Equal(isLegacy, skin.IsLegacy);
    }

    [Theory]
    [InlineData("PotatoMaster101", false)]
    [InlineData("MHF_Pig", true)]
    public async Task FromUsername_ReturnsSkin(string username, bool isLegacy)
    {
        // act
        using var skin = await SkinGrabber.FromUsername(username);

        // assert
        Assert.Equal(isLegacy, skin.IsLegacy);
    }

    [Theory]
    [InlineData("cb2671d590b84dfe9b1c73683d451d1a", false)]
    [InlineData("8b57078bf1bd45df83c4d88d16768fbe", true)]
    public async Task FromUuid_ReturnsSkin(string uuid, bool isLegacy)
    {
        // act
        using var skin = await SkinGrabber.FromUuid(uuid);

        // assert
        Assert.Equal(isLegacy, skin.IsLegacy);
    }
}
