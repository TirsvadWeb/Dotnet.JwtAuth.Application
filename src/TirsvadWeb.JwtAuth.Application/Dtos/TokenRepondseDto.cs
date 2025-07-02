namespace TirsvadWeb.JwtAuth.Application.Dtos;

/// <summary>
/// Represents a response containing authentication tokens.
/// </summary>
public class TokenRepondseDto
{
    /// <summary>
    /// Gets or sets the access token issued to the user.
    /// </summary>
    public required string AccessToken { get; set; }

    /// <summary>
    /// Gets or sets the refresh token issued to the user.
    /// </summary>
    public required string RefreshToken { get; set; }
}