using MojSharp.Profile;
using MojSharp.Uuid;

namespace McSkin;

/// <summary>
/// Helper methods for retrieving player skins.
/// </summary>
public static class SkinGrabber
{
    /// <summary>
    /// HTTP client for downloading skin.
    /// </summary>
    private static readonly HttpClient Client = new();

    /// <summary>
    /// Retrieves a player skin from an image file.
    /// </summary>
    /// <param name="path">The skin image file path.</param>
    /// <param name="cancellationToken">The cancellation token for cancelling the operation.</param>
    /// <returns>Player skin from an image file.</returns>
    /// <exception cref="ArgumentException">Thrown when the skin image is invalid.</exception>
    public static async Task<Skin> FromFile(string path, CancellationToken cancellationToken = default)
    {
        return new Skin(await Image.LoadAsync(path, cancellationToken));
    }

    /// <summary>
    /// Retrieves a player skin using Minecraft username.
    /// </summary>
    /// <param name="username">Minecraft username for the skin.</param>
    /// <param name="cancellationToken">The cancellation token for cancelling the operation.</param>
    /// <returns>Player skin from Minecraft username.</returns>
    /// <exception cref="ArgumentException">Thrown when username doesn't have associated skin.</exception>
    public static async Task<Skin> FromUsername(string username, CancellationToken cancellationToken = default)
    {
        var response = await new UuidRequest(username).Request(cancellationToken).ConfigureAwait(false);
        return await FromUuid(response.Player.Uuid, cancellationToken).ConfigureAwait(false);
    }

    /// <summary>
    /// Retrieves a player skin using Minecraft player UUID.
    /// </summary>
    /// <param name="uuid">Minecraft player UUID for the skin.</param>
    /// <param name="cancellationToken">The cancellation token for cancelling the operation.</param>
    /// <returns>Player skin from Minecraft player UUID.</returns>
    /// <exception cref="ArgumentException">Thrown when UUID doesn't have associated skin.</exception>
    public static async Task<Skin> FromUuid(string uuid, CancellationToken cancellationToken = default)
    {
        var response = await new ProfileRequest(uuid).Request(cancellationToken).ConfigureAwait(false);
        var texture = response.GetTextures();
        if (texture?.Skin is null)
            throw new ArgumentException("No skin found", nameof(uuid));

        var skinBytes = await Client.GetStreamAsync(texture.Skin.Url, cancellationToken).ConfigureAwait(false);
        var skin = await Image.LoadAsync(skinBytes, cancellationToken).ConfigureAwait(false);
        return new Skin(skin);
    }
}
