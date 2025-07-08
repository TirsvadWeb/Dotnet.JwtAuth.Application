using TirsvadWeb.JwtAuth.Application.Dtos;
using TirsvadWeb.JwtAuth.Domain.Entities;

namespace TirsvadWeb.JwtAuth.Application.Services;

/// <summary>
/// Defines authentication-related operations for user registration, login, and token refresh.
/// </summary>
public interface IAuthService
{
    /// <summary>
    /// Registers a new user asynchronously.
    /// </summary>
    /// <param name="request">The user registration data.</param>
    /// <returns>
    /// A <see cref="ApplicationUser"/> instance if registration is successful; otherwise, <c>null</c>.
    /// </returns>
    Task<ApplicationUser?> RegisterAsync(ApplicationUserDto request);

    /// <summary>
    /// Authenticates a user and generates access and refresh tokens asynchronously.
    /// </summary>
    /// <param name="request">The user login data.</param>
    /// <returns>
    /// A <see cref="TokenRepondseDto"/> containing tokens if authentication is successful; otherwise, <c>null</c>.
    /// </returns>
    Task<TokenRepondseDto?> LoginAsync(ApplicationUserDto request);

    /// <summary>
    /// Refreshes access and refresh tokens asynchronously using a valid refresh token.
    /// </summary>
    /// <param name="request">The refresh token request data.</param>
    /// <returns>
    /// A <see cref="TokenRepondseDto"/> containing new tokens if the refresh is successful; otherwise, <c>null</c>.
    /// </returns>
    Task<TokenRepondseDto?> RefreshTokensAsync(RefreshTokenRequestDto request);
}