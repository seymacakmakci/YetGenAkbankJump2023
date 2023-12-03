using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Productify.Domain.Entities;
using Productify.Persistance.Context;

namespace Productify.MVC.Controllers
{
    public class ProductController : Controller
    {
        ProductifyDbContext _context;

        public ProductController()
        {
            _context = new();
        }
        // GET: ProductController
        public IActionResult GetAll()
        {
            return View(_context.Products.ToList());
        }

        // GET: AddProductController
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View(_context.Products.ToList());
        }

        [HttpPost]
        public IActionResult AddProduct(string productName)
        {
            _context.Products.Add(new(productName));
            _context.SaveChanges();
            return View();
        }
    }
}