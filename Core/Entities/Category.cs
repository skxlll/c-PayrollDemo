using System.ComponentModel.DataAnnotations;

namespace PayrollDemo.Core.Entities;

public class Category
{
    [Key]
    public string CatCode { get; set; } = string.Empty;

    [Required]
    public string CatName { get; set; } = string.Empty;
}
