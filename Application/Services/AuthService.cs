using Microsoft.EntityFrameworkCore;
using PayrollDemo.Core.Entities;
using PayrollDemo.Core.Interfaces;
using PayrollDemo.Infrastructure.Data;

namespace PayrollDemo.Application.Services;

public class AuthService : IAuthService
{
    private readonly PayrollDbContext _dbContext;

    public AuthService(PayrollDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <inheritdoc />
    public async Task<User?> ValidateUserAsync(string username, string password)
    {
        return await _dbContext.Users
            .FirstOrDefaultAsync(u => u.Username == username && u.Password == password);
    }

    /// <inheritdoc />
    public async Task<List<Company>> GetCompaniesAsync()
    {
        return await _dbContext.Companies.ToListAsync();
    }

    /// <inheritdoc />
    public async Task<List<Category>> GetCategoriesAsync()
    {
        return await _dbContext.Categories.ToListAsync();
    }
}
