
namespace Test.Domain.Models.Product;

public class ProductUM
{
    public string ProductId { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Description { get; set; }
    
    public string CategoryId { get; set; }
}