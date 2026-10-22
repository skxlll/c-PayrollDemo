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
    public string Password { get; set; } = string.Empty; // Note: For this demo only. Real apps must hash passwords!
}

public class PayrollDbContext : DbContext
{
    public PayrollDbContext(DbContextOptions<PayrollDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
}