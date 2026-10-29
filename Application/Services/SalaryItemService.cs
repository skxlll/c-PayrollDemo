using Microsoft.EntityFrameworkCore;
using PayrollDemo.Core.Entities;
using PayrollDemo.Core.Interfaces;
using PayrollDemo.Infrastructure.Data;

namespace PayrollDemo.Application.Services;

public class SalaryItemService : ISalaryItemService
{
    private readonly PayrollDbContext _context;

    public SalaryItemService(PayrollDbContext context)
    {
        _context = context;
    }

    public async Task<List<SalaryItem>> GetAllSalaryItemsAsync()
    {
        return await _context.SalaryItems
            .OrderBy(s => s.TxnCode)
            .AsNoTracking()
            .ToListAsync();
    }

    public async Task AddSalaryItemAsync(SalaryItem salaryItem)
    {
        _context.SalaryItems.Add(salaryItem);
        await _context.SaveChangesAsync();
        _context.ChangeTracker.Clear();
    }

    public async Task UpdateSalaryItemAsync(SalaryItem salaryItem)
    {
        _context.SalaryItems.Update(salaryItem);
        await _context.SaveChangesAsync();
        _context.ChangeTracker.Clear();
    }

    public async Task DeleteSalaryItemAsync(string txnCode)
    {
        var item = await _context.SalaryItems.FindAsync(txnCode);
        if (item != null)
        {
            _context.SalaryItems.Remove(item);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.Clear();
        }
    }
}