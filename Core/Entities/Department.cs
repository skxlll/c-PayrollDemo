using System.ComponentModel.DataAnnotations;

namespace PayrollDemo.Core.Entities;

public class Department
{
    [Key]
    [MaxLength(10)]
    public string DepCode { get; set; } = string.Empty;

    [Required]
    public string DepName { get; set; } = string.Empty;

    // Navigation property mapping back to Employees
    public ICollection<Employee> Employees { get; set; } = new List<Employee>();
}