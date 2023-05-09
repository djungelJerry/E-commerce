using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.E_Commerce.Models;

namespace MVC.E_Commerce.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationContext Context;
        public ProductsController(ApplicationContext _context)
        {
            Context = _context;
        }
        public IActionResult Index()
        {
            List<Product> AllProducts = Context.Products.Include(t => t.Tags).ToList();
            return View(AllProducts);
        }
        public IActionResult Details(int id)
        {
            Product CurrentProduct = new Product();
            CurrentProduct = Context.Products.Where(x => x.Id == id).FirstOrDefault();
            return View(CurrentProduct);
        }       
        public IActionResult IndexSek(int id)
        {
            List<Product> AllProducts = Context.Products.Include(t => t.Tags).ToList();
            foreach (Product product in AllProducts)
            {
                product.ProductPrice *= 10;
            }
            return View(AllProducts);
        }
        public IActionResult DetailsSek(int id)
        {
            Product CurrentProduct = Context.Products.Where(x => x.Id == id).FirstOrDefault();
            CurrentProduct.ProductPrice *= 10;
            return View(CurrentProduct);
        }
    }
}

