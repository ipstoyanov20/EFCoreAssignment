﻿namespace Test.Domain.Models.Product;

public class ProductIM
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
    public string Description { get; set; }
    public int CategoryId { get; set; }
}