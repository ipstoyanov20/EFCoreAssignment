using System;
using System.ComponentModel.DataAnnotations;

namespace Test.Data.Models;

public class Customer
{
    [Key]
    public string CustomerId { get; set; } = Guid.NewGuid().ToString();

    [Required]
    [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters.")]
    public string Name { get; set; }

    [Required]
    [EmailAddress(ErrorMessage = "Invalid email address format.")]
    public string Email { get; set; }

    [Phone(ErrorMessage = "Invalid phone number format.")]
    public string PhoneNumber { get; set; }

    [StringLength(200, ErrorMessage = "Address cannot exceed 200 characters.")]
    public string Address { get; set; }

    [Required]
    public DateTime DateRegistered { get; set; }
}