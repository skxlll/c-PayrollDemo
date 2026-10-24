using System.ComponentModel.DataAnnotations;

namespace PayrollDemo.Core.Entities;

public class Company
{
    [Key]
    public string ComCode { get; set; } = string.Empty;

    [Required]
    public string ComName { get; set; } = string.Empty;
}
