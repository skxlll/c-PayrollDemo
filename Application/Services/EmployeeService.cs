using Microsoft.EntityFrameworkCore;
using PayrollDemo.Core.Entities;
using PayrollDemo.Core.Interfaces;
using PayrollDemo.Infrastructure.Data;

namespace PayrollDemo.Application.Services;

public class EmployeeService : IEmployeeService
{
    private readonly PayrollDbContext _context;

    public EmployeeService(PayrollDbContext context)
    {
        _context = context;
    }

    public async Task<List<Employee>> GetAllEmployeesAsync()
    {
        return await _context.Employees
            .OrderBy(e => e.EmpNo)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task AddEmployeeAsync(Employee employee)
    {
        _context.Employees.Add(employee);
        await _context.SaveChangesAsync();
        _context.ChangeTracker.Clear(); // Clears EF memory to prevent tracking collisions
    }

    public async Task UpdateEmployeeAsync(Employee employee)
    {
        _context.Employees.Update(employee);
        await _context.SaveChangesAsync();
        _context.ChangeTracker.Clear(); // Clears EF memory to prevent tracking collisions
    }

    public async Task DeleteEmployeeAsync(string empNo)
    {
        var emp = await _context.Employees.FindAsync(empNo);
        if (emp != null)
        {
            _context.Employees.Remove(emp);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear(); // Clears EF memory to prevent tracking collisions
        }
    }
}