using System.ComponentModel.DataAnnotations;

namespace PayrollDemo.Core.Entities;

public class SalaryItem
{
    [Key]
    [MaxLength(10)]
    public string TxnCode { get; set; } = string.Empty;

    [Required]
    [MaxLength(150)]
    public string Description { get; set; } = string.Empty;
}