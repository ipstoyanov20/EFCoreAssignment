using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Data.Models;


public class Sale
{
    [Key]
    public string SaleId { get; set; } = Guid.NewGuid().ToString();

    [Required]
    public string CustomerId { get; set; }

    [ForeignKey(nameof(CustomerId))]
    public Customer Customer { get; set; }

    [Required]
    public string ProductId { get; set; }

    [ForeignKey(nameof(ProductId))]
    public Product Product { get; set; }

    [Required]
    [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
    public int Quantity { get; set; }

    [Required]
    public DateTime SaleDate { get; set; }

    [Required]
    [Range(0.01, double.MaxValue, ErrorMessage = "Total price must be greater than zero.")]
    public decimal TotalPrice { get; set; }
}