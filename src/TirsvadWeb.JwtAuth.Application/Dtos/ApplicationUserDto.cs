namespace TirsvadWeb.JwtAuth.Application.Dtos;

/// <summary>
/// Represents user credentials for authentication or registration.
/// </summary>
public class ApplicationUserDto
{
    /// <summary>
    /// Gets or sets the username of the user.
    /// </summary>
    public string UserName { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the password of the user.
    /// </summary>
    public string Password { get; set; } = string.Empty;
}