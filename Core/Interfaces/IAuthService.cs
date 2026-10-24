using PayrollDemo.Core.Entities;

namespace PayrollDemo.Core.Interfaces;

public interface IAuthService
{
    /// <summary>
    /// Validates the supplied credentials against the database.
    /// Returns the matched <see cref="User"/> or <c>null</c> if the credentials are invalid.
    /// </summary>
    Task<User?> ValidateUserAsync(string username, string password);

    /// <summary>
    /// Retrieves all companies available for selection after a successful login.
    /// </summary>
    Task<List<Company>> GetCompaniesAsync();

    /// <summary>
    /// Retrieves all categories available for selection after a successful login.
    /// </summary>
    Task<List<Category>> GetCategoriesAsync();
}
