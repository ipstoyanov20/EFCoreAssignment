namespace Test.Domain.Models.Sale;

public class SaleVM
{
    public string SaleId { get; set; }
    public string CustomerName { get; set; }
    public string ProductName { get; set; }
    public int Quantity { get; set; }
    public DateTime SaleDate { get; set; }
    public decimal TotalPrice { get; set; }
}