using System;
using System.ComponentModel.DataAnnotations;

namespace Test.Data.Models;
public class Category
{
    [Key]
    [Required]
    public string CategoryId { get; set; } = Guid.NewGuid().ToString();

    [Required]
    [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
    public string Name { get; set; }

    [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
    public string Description { get; set; }
}