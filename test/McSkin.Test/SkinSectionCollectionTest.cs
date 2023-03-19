using Xunit;

namespace McSkin.Test;

/// <summary>
/// Unit tests for <see cref="SkinSectionCollection"/>.
/// </summary>
public class SkinSectionCollectionTest
{
    [Theory]
    [InlineData(SkinSectionId.All, 0, 0, 64, 64)]
    public void Get_GetsSection(SkinSectionId id, int x, int y, int width, int height)
    {
        // act
        var actual = SkinSectionCollection.Get(id);

        // assert
        Assert.Equal(x, actual.X);
        Assert.Equal(y, actual.Y);
        Assert.Equal(width, actual.Width);
        Assert.Equal(height, actual.Height);
    }
}
