namespace McSkin;

/// <summary>
/// Represents a Minecraft player skin.
/// </summary>
public class Skin : IDisposable
{
    /// <summary>
    /// Legacy skin height in pixels.
    /// </summary>
    public const int LegacyHeight = 32;

    /// <summary>
    /// Standard skin height in pixels.
    /// </summary>
    public const int StandardHeight = 64;

    /// <summary>
    /// Standard skin width in pixels.
    /// </summary>
    public const int StandardWidth = 64;

    /// <summary>
    /// Gets whether this skin is a legacy skin.
    /// </summary>
    public bool IsLegacy => SkinImage.Height == LegacyHeight;

    /// <summary>
    /// Player skin image.
    /// </summary>
    public Image SkinImage { get; }

    /// <summary>
    /// Constructs a new instance of <see cref="Skin"/>.
    /// </summary>
    /// <param name="isLegacy">Whether the skin is a legacy skin.</param>
    public Skin(bool isLegacy = false) : this(new Image<Rgba32>(StandardWidth, isLegacy ? LegacyHeight : StandardHeight))
    { }

    /// <summary>
    /// Constructs a new instance of <see cref="Skin"/>.
    /// </summary>
    /// <param name="skin">The player skin image.</param>
    /// <exception cref="ArgumentException">Thrown when the skin dimension is invalid.</exception>
    public Skin(Image skin)
    {
        if (skin.Height != LegacyHeight && skin.Height != StandardHeight)
            throw new ArgumentException("Invalid height", nameof(skin));
        if (skin.Width != StandardWidth)
            throw new ArgumentException("Invalid width", nameof(skin));

        SkinImage = skin;
    }

    /// <summary>
    /// Returns a section of the skin.
    /// </summary>
    /// <param name="section">The skin section.</param>
    /// <returns>A section of the skin.</returns>
    /// <exception cref="InvalidOperationException">Thrown when section cannot be used on current skin.</exception>
    public Image GetSection(SkinSection section)
    {
        if (IsLegacy && section.LegacyEquivalentSection is not null)
            section = section.LegacyEquivalentSection;
        else if (IsLegacy && !section.CanUseOnLegacy)
            throw new InvalidOperationException("Cannot use on legacy skin");

        return SkinImage.Clone(c => c.Crop(section.Rect));
    }

    /// <summary>
    /// Copies a section from this skin to another skin.
    /// </summary>
    /// <param name="section">The section to copy.</param>
    /// <param name="destination">The destination skin.</param>
    public void CopySectionTo(SkinSection section, Skin destination)
    {
        var sectImage = GetSection(section);
        destination.SkinImage.Mutate(c => c.DrawImage(sectImage, section.Point, 1));
    }

    /// <summary>
    /// Saves this skin to a file.
    /// </summary>
    /// <param name="path">The path to output image file.</param>
    /// <param name="cancellationToken">The cancellation token for cancelling the operation.</param>
    public Task Save(string path, CancellationToken cancellationToken = default)
    {
        if (!path.EndsWith(".png"))
            path += ".png";

        return SkinImage.SaveAsync(path, cancellationToken);
    }

    /// <inheritdoc cref="IDisposable.Dispose"/>
    public void Dispose()
    {
        SkinImage.Dispose();
        GC.SuppressFinalize(this);
    }
}
