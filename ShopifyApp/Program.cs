using ShopifyApp.Context;
using ShopifyApp.Entities;

Console.WriteLine("PostgreSQL Exercise");

ShopifyDbContext _context = new();

#region AddSingle
Product product1 = new Product("Laptop", 2.5m, 999.99m);
_context.Products.Add(product1);

_context.SaveChanges();
#endregion

#region AddMultiple
List<Product> Allproducts = new List<Product>
{
     new Product("Television", 15.0m, 1099.99m),
     new Product("Headphones", 0.15m, 69.99m),
     new Product("Coffee Maker", 5.0m, 179.99m),
     new Product("Tablet", 0.6m, 499.99m),
     new Product("Smartphone", 0.4m, 799.99m),
     new Product("Washing Machine", 30.0m, 899.99m)

};
_context.Products.AddRange(Allproducts);
_context.SaveChanges();
#endregion