using PayrollDemo.Core.Entities;

namespace PayrollDemo.Core.Interfaces;

public interface IDepartmentService
{
    Task<List<Department>> GetAllDepartmentsAsync();
    Task AddDepartmentAsync(Department department);
    Task UpdateDepartmentAsync(Department department);
    Task DeleteDepartmentAsync(string depCode);
}