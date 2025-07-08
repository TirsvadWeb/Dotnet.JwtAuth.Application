namespace TirsvadWeb.JwtAuth.Application.Dtos;

/// <summary>
/// Represents a request to refresh authentication tokens.
/// </summary>
public class RefreshTokenRequestDto
{
    /// <summary>
    /// Gets or sets the unique identifier of the user requesting the token refresh.
    /// </summary>
    public Guid ApplicationUserId { get; set; }

    /// <summary>
    /// Gets or sets the refresh token used to obtain new authentication tokens.
    /// </summary>
    public required string RefreshToken { get; set; }
}