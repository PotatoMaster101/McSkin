namespace McSkin;

/// <summary>
/// Represents a section of a skin.
/// </summary>
public class SkinSection
{
    /// <summary>
    /// Maximum X position.
    /// </summary>
    public const int MaxX = 63;

    /// <summary>
    /// Maximum Y position.
    /// </summary>
    public const int MaxY = 63;

    /// <summary>
    /// Gets the starting X position.
    /// </summary>
    public int X { get; }

    /// <summary>
    /// Gets the starting Y position.
    /// </summary>
    public int Y { get; }

    /// <summary>
    /// Gets the section width.
    /// </summary>
    public int Width { get; }

    /// <summary>
    /// Gets the section height.
    /// </summary>
    public int Height { get; }

    /// <summary>
    /// Gets the equivalent section that can be used on legacy skins.
    /// </summary>
    public SkinSection? LegacyEquivalentSection { get; }

    /// <summary>
    /// Gets whether this section can be used on a legacy skin.
    /// </summary>
    public bool CanUseOnLegacy => Y + Height <= Skin.LegacyHeight;

    /// <summary>
    /// Gets a rectangle representing this section.
    /// </summary>
    public Rectangle Rect => new(X, Y, Width, Height);

    /// <summary>
    /// Gets a point representing this section.
    /// </summary>
    public Point Point => new(X, Y);

    /// <summary>
    /// Constructs a new instance of <see cref="SkinSection"/>.
    /// </summary>
    /// <param name="rect">The rectangle containing the position and size.</param>
    /// <param name="legacyEquivalent">The equivalent section that can be used on legacy skins.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when any argument is out of range.</exception>
    public SkinSection(Rectangle rect, SkinSection? legacyEquivalent = null)
        : this(rect.X, rect.Y, rect.Width, rect.Height, legacyEquivalent) { }

    /// <summary>
    /// Constructs a new instance of <see cref="SkinSection"/>.
    /// </summary>
    /// <param name="x">The starting X position.</param>
    /// <param name="y">The starting Y position.</param>
    /// <param name="width">The section width.</param>
    /// <param name="height">The section height.</param>
    /// <param name="legacyEquivalent">The equivalent section that can be used on legacy skins.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown when any argument is out of range.</exception>
    public SkinSection(int x, int y, int width, int height, SkinSection? legacyEquivalent = null)
    {
        if (x is < 0 or > MaxX)
            throw new ArgumentOutOfRangeException(nameof(x));
        if (y is < 0 or > MaxY)
            throw new ArgumentOutOfRangeException(nameof(y));
        if (width < 1 || x + width > Skin.StandardWidth)
            throw new ArgumentOutOfRangeException(nameof(width));
        if (height < 1 || y + height > Skin.StandardHeight)
            throw new ArgumentOutOfRangeException(nameof(height));

        X = x;
        Y = y;
        Width = width;
        Height = height;
        LegacyEquivalentSection = legacyEquivalent;
    }
}
