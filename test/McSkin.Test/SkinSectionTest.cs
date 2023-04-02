using SixLabors.ImageSharp;
using Xunit;

namespace McSkin.Test;

/// <summary>
/// Unit tests for <see cref="SkinSection"/>.
/// </summary>
public class SkinSectionTest
{
    [Theory]
    [InlineData(0, 0, Skin.StandardWidth, Skin.StandardHeight)]
    [InlineData(0, 0, Skin.StandardWidth, Skin.LegacyHeight)]
    [InlineData(32, 32, 32, 32)]
    [InlineData(0, 0, 1, 1)]
    public void Constructor1_SetsMember(int x, int y, int width, int height)
    {
        // arrange
        var rect = new Rectangle(x, y, width, height);

        // act
        var section = new SkinSection(rect);

        // assert
        Assert.Equal(x, section.X);
        Assert.Equal(y, section.Y);
        Assert.Equal(width, section.Width);
        Assert.Equal(height, section.Height);
        Assert.Null(section.LegacyEquivalentSection);
    }

    [Theory]
    [InlineData(0, 0, Skin.StandardWidth, Skin.StandardHeight)]
    [InlineData(0, 0, Skin.StandardWidth, Skin.LegacyHeight)]
    [InlineData(32, 32, 32, 32)]
    [InlineData(0, 0, 1, 1)]
    public void Constructor2_SetsMember(int x, int y, int width, int height)
    {
        // act
        var section = new SkinSection(x, y, width, height);

        // assert
        Assert.Equal(x, section.X);
        Assert.Equal(y, section.Y);
        Assert.Equal(width, section.Width);
        Assert.Equal(height, section.Height);
        Assert.Null(section.LegacyEquivalentSection);
    }

    [Theory]
    [InlineData(0, 0, Skin.StandardWidth, Skin.StandardHeight + 1)]
    [InlineData(0, 0, Skin.StandardWidth + 1, Skin.StandardHeight)]
    [InlineData(1, 0, Skin.StandardWidth, Skin.StandardHeight)]
    [InlineData(0, 1, Skin.StandardWidth, Skin.StandardHeight)]
    [InlineData(SkinSection.MaxX + 1, 0, 1, 1)]
    [InlineData(0, SkinSection.MaxY + 1, 1, 1)]
    [InlineData(-1, 0, 1, 1)]
    [InlineData(0, -1, 1, 1)]
    [InlineData(0, 0, 0, 0)]
    public void Constructor2_ThrowsOnOutOfRange(int x, int y, int width, int height)
    {
        // assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new SkinSection(x, y, width, height));
    }

    [Theory]
    [InlineData(0, 0, Skin.StandardWidth, Skin.LegacyHeight - 1, true)]
    [InlineData(0, 0, Skin.StandardWidth, 1, true)]
    [InlineData(0, 1, Skin.StandardWidth, Skin.LegacyHeight, false)]
    [InlineData(0, 32, Skin.StandardWidth, 1, false)]
    public void CanUseOnLegacy_ReturnsCorrectValue(int x, int y, int width, int height, bool expected)
    {
        // arrange
        var section = new SkinSection(x, y, width, height);

        // act
        var actual = section.CanUseOnLegacy;

        // assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(0, 0, Skin.StandardWidth, Skin.StandardHeight)]
    [InlineData(0, 0, Skin.StandardWidth, Skin.LegacyHeight)]
    [InlineData(32, 32, 32, 32)]
    [InlineData(0, 0, 1, 1)]
    public void Rect_ReturnsCorrectValue(int x, int y, int width, int height)
    {
        // arrange
        var section = new SkinSection(x, y, width, height);

        // act
        var actual = section.Rect;

        // assert
        Assert.Equal(x, actual.X);
        Assert.Equal(y, actual.Y);
        Assert.Equal(width, actual.Width);
        Assert.Equal(height, actual.Height);
    }

    [Theory]
    [InlineData(0, 0)]
    [InlineData(12, 34)]
    public void Point_ReturnsCorrectValue(int x, int y)
    {
        // arrange
        var section = new SkinSection(x, y, 1, 1);

        // act
        var actual = section.Point;

        // assert
        Assert.Equal(x, actual.X);
        Assert.Equal(y, actual.Y);
    }
}
