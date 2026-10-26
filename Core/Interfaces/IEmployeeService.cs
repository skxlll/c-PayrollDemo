using PayrollDemo.Core.Entities;

namespace PayrollDemo.Core.Interfaces;

public interface IEmployeeService
{
    Task<List<Employee>> GetAllEmployeesAsync();
    Task AddEmployeeAsync(Employee employee);
    Task UpdateEmployeeAsync(Employee employee);
    Task DeleteEmployeeAsync(string empNo);
}