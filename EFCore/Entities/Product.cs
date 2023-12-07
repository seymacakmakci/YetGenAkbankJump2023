using EFCore.Entities;
using EFCore.Common;


public class Product : EntityBase<int>
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int CategoryId { get; set; }
    public Category Category { get; set; }

    public Product(string name, decimal price, Category category) : base(0, DateTimeOffset.UtcNow)
    {
        Name = name;
        Price = price;
        Category = category;
    }
}
