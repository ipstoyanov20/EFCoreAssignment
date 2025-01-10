using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Test.Domain.Models.Sale;

public class SaleUM
{
    public string SaleId { get; set; }
    public string CustomerId { get; set; }
    
    public string ProductId { get; set; }
    public int Quantity { get; set; }
    public DateTime SaleDate { get; set; }
}