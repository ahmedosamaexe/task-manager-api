namespace TaskManagerAPI.Services;

public interface IAuthService
{
    /// <summary>
    /// Registers a new user. Returns an error message if username/email already exists, or null on success.
    /// </summary>
    Task<string?> RegisterAsync(string username, string email, string password);

    /// <summary>
    /// Validates credentials and returns a JWT token, or null if credentials are invalid.
    /// </summary>
    Task<string?> LoginAsync(string email, string password);
}
