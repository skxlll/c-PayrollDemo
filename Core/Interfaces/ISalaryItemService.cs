using PayrollDemo.Core.Entities;

namespace PayrollDemo.Core.Interfaces;

public interface ISalaryItemService
{
    Task<List<SalaryItem>> GetAllSalaryItemsAsync();
    Task AddSalaryItemAsync(SalaryItem salaryItem);
    Task UpdateSalaryItemAsync(SalaryItem salaryItem);
    Task DeleteSalaryItemAsync(string txnCode);
}