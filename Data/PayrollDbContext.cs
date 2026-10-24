using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace PayrollDemo.Data;

public class User
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Username { get; set; } = string.Empty;

    [Required]
    public string Password { get; set; } = string.Empty;
}

public class Company
{
    [Key]
    public string ComCode { get; set; } = string.Empty;
    [Required]
    public string ComName { get; set; } = string.Empty;
}

public class Category
{
    [Key]
    public string CatCode { get; set; } = string.Empty;
    [Required]
    public string CatName { get; set; } = string.Empty;
}

public class PayrollDbContext : DbContext
{
    public PayrollDbContext(DbContextOptions<PayrollDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Category> Categories { get; set; }
}