using EFCore.Entities;
using EFCore.Persistence;

// Create an instance of EFCoreDbContext class
EFCoreDbContext _context = new EFCoreDbContext();

// Create categories
var categoryPencil = new Category(1, DateTimeOffset.UtcNow, "Pencil");
var categoryBook = new Category(2, DateTimeOffset.UtcNow, "Book");

// Add products
_context.Products.Add(new Product("Pencil 1", 100, categoryPencil));
_context.Products.Add(new Product("Pencil 2", 100, categoryPencil));
_context.Products.Add(new Product("Book 1", 100, categoryBook));
_context.Products.Add(new Product("Book 2", 100, categoryBook));

// Insert operation
_context.Products.AddRange(new List<Product>
{
    new Product("Pencil 3", 200, categoryPencil),
    new Product("Pencil 4", 300, categoryPencil),
    new Product("Book 3", 200, categoryBook),
    new Product("Book 4", 300, categoryBook),
});

// Save changes
_context.SaveChanges();

// Remove a product
var productToRemove = _context.Products.FirstOrDefault(x => x.Name == "Pencil 1");
if (productToRemove != null)
{
    _context.Products.Remove(productToRemove);
    _context.SaveChanges();
}

// Update a product
var productToUpdate = _context.Products.FirstOrDefault();
if (productToUpdate != null)
{
    productToUpdate.Name = "Pencil 200";
    _context.SaveChanges();
}

// List all products
List<Product> products = _context.Products.ToList();

// Print to the console
Console.WriteLine("Products:");
foreach (var product in products)
{
    Console.WriteLine($"{product.Id}: {product.Name} - {product.Price}");
}

