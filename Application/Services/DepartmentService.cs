using Microsoft.EntityFrameworkCore;
using PayrollDemo.Core.Entities;
using PayrollDemo.Core.Interfaces;
using PayrollDemo.Infrastructure.Data;

namespace PayrollDemo.Application.Services;

public class DepartmentService : IDepartmentService
{
    private readonly PayrollDbContext _context;

    public DepartmentService(PayrollDbContext context)
    {
        _context = context;
    }

    public async Task<List<Department>> GetAllDepartmentsAsync()
    {
        return await _context.Departments
            .OrderBy(d => d.DepCode)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task AddDepartmentAsync(Department department)
    {
        _context.Departments.Add(department);
        await _context.SaveChangesAsync();
        _context.ChangeTracker.Clear();
    }

    public async Task UpdateDepartmentAsync(Department department)
    {
        _context.Departments.Update(department);
        await _context.SaveChangesAsync();
        _context.ChangeTracker.Clear();
    }

    public async Task DeleteDepartmentAsync(string depCode)
    {
        var dept = await _context.Departments.FindAsync(depCode);
        if (dept != null)
        {
            _context.Departments.Remove(dept);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
        }
    }
}