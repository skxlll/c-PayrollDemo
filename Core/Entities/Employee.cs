using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PayrollDemo.Core.Entities;

public class Employee
{
    [Key]
    public string EmpNo { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string NicNo { get; set; } = string.Empty;
    public DateTime JoinDate { get; set; } = DateTime.Today;
    public DateTime? ResignDate { get; set; }
    [Column(TypeName = "decimal(18, 2)")]
    public decimal BasicSalary { get; set; }

    public string DepartmentCode { get; set; } = string.Empty;
    public string BankCode { get; set; } = string.Empty;
    public string BankAccountNumber { get; set; } = string.Empty;
}