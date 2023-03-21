using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;
using Xunit;

namespace McSkin.Test;

/// <summary>
/// Unit tests for <see cref="Skin"/>.
/// </summary>
public class SkinTest
{
    [Theory]
    [InlineData(true)]
    [InlineData(false)]
    public void Ctor1_SetsMembers(bool isLegacy)
    {
        // act
        using var skin = new Skin(isLegacy);

        // assert
        Assert.Equal(isLegacy, skin.IsLegacy);
        Assert.Equal(Skin.StandardWidth, skin.SkinImage.Width);
        Assert.Equal(isLegacy ? Skin.LegacyHeight : Skin.StandardHeight, skin.SkinImage.Height);
    }

    [Theory]
    [InlineData(Skin.StandardWidth, Skin.StandardHeight, false)]
    [InlineData(Skin.StandardWidth, Skin.LegacyHeight, true)]
    public void Ctor2_SetsMembers(int skinWidth, int skinHeight, bool isLegacy)
    {
        // act
        using var skin = new Skin(new Image<Rgba32>(skinWidth, skinHeight));

        // assert
        Assert.Equal(isLegacy, skin.IsLegacy);
        Assert.Equal(skinWidth, skin.SkinImage.Width);
        Assert.Equal(skinHeight, skin.SkinImage.Height);
    }

    [Theory]
    [InlineData(65, Skin.StandardHeight)]
    [InlineData(Skin.StandardWidth, 65)]
    [InlineData(65, 65)]
    public void Ctor2_ThrowsOnInvalidParams(int skinWidth, int skinHeight)
    {
        // arrange
        using var image = new Image<Rgba32>(skinWidth, skinHeight);

        // assert
        Assert.Throws<ArgumentException>(() => new Skin(image));
    }

    [Theory]
    [InlineData(0, 0, Skin.StandardWidth, Skin.StandardHeight)]
    [InlineData(0, 0, Skin.StandardWidth, Skin.LegacyHeight)]
    public void GetSection_ReturnsCorrectValue(int x, int y, int width, int height)
    {
        // arrange
        using var skin = new Skin(new Image<Rgba32>(Skin.StandardWidth, Skin.StandardHeight));
        var sect = new SkinSection(x, y, width, height);

        // act
        using var section = skin.GetSection(sect);

        // assert
        Assert.Equal(width, section.Width);
        Assert.Equal(height, section.Height);
    }

    [Theory]
    [InlineData(0, 0, 8, 8)]
    public void GetSection_UsesToLegacySection(int legacyX, int legacyY, int legacyWidth, int legacyHeight)
    {
        // arrange
        using var skin = new Skin(new Image<Rgba32>(Skin.StandardWidth, Skin.LegacyHeight));
        var legacySect = new SkinSection(legacyX, legacyY, legacyWidth, legacyHeight);
        var sect = new SkinSection(0, 0, Skin.StandardWidth, Skin.StandardHeight, legacySect);

        // act
        using var section = skin.GetSection(sect);

        // assert
        Assert.Equal(legacyWidth, section.Width);
        Assert.Equal(legacyHeight, section.Height);
    }

    [Theory]
    [InlineData(0, 0, 8, 8)]
    [InlineData(8, 8, 32, 32)]
    [InlineData(32, 32, 32, 32)]
    public void CopySectionTo_CopiesSection(int x, int y, int width, int height)
    {
        // arrange
        var skinImage = new Image<Rgba32>(Skin.StandardWidth, Skin.StandardHeight, new Rgba32(0, 0, 0));
        var drawImage = new Image<Rgba32>(width, height, new Rgba32(255, 255, 255));
        skinImage.Mutate(c => c.DrawImage(drawImage, new Point(x, y), 1));

        using var skin1 = new Skin(skinImage);
        using var skin2 = new Skin();
        var section = new SkinSection(x, y, width, height);

        // act
        skin1.CopySectionTo(section, skin2);

        // assert
        var testImage = (Image<Rgba32>)skin2.SkinImage;
        var expectedRgba = drawImage[0, 0].Rgba;
        for (var r = x; r < x + width; r++)
            for (var c = y; c < y + height; c++)
                Assert.Equal(expectedRgba, testImage[r, c].Rgba);
    }

    [Theory]
    [InlineData(0, 0, Skin.StandardWidth, Skin.StandardHeight)]
    [InlineData(0, 0, Skin.StandardWidth, Skin.LegacyHeight + 1)]
    public void GetSection_ThrowsOnInvalidOperation(int x, int y, int width, int height)
    {
        // arrange
        using var skin = new Skin(new Image<Rgba32>(Skin.StandardWidth, Skin.LegacyHeight));
        var sect = new SkinSection(x, y, width, height);

        // assert
        Assert.Throws<InvalidOperationException>(() => skin.GetSection(sect));
    }

    [Theory]
    [InlineData("test")]
    [InlineData("test.png")]
    public async Task Save_SavesSkin(string path)
    {
        // arrange
        var expected = path.EndsWith(".png") ? path : $"{path}.png";
        using var skin = new Skin(new Image<Rgba32>(Skin.StandardWidth, Skin.StandardHeight));

        // act
        await skin.Save(path);

        // assert
        Assert.True(File.Exists(expected));
    }
}
