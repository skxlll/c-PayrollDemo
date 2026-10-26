using Microsoft.EntityFrameworkCore;
using PayrollDemo.Core.Entities;

namespace PayrollDemo.Infrastructure.Data;

public class PayrollDbContext : DbContext
{
    public PayrollDbContext(DbContextOptions<PayrollDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Company> Companies { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Employee> Employees { get; set; }
}
