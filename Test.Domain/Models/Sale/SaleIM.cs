
namespace Test.Domain.Models.Sale;

public class SaleIM
{
    public string CustomerId { get; set; }
    public string ProductId { get; set; }
    public int Quantity { get; set; }
    public DateTime SaleDate { get; set; }
}