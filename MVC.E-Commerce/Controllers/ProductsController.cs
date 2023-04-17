using Microsoft.AspNetCore.Mvc;
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
            List<Product> AllProducts = Context.Products.ToList();
            return View(AllProducts);
        }
        public IActionResult Details(int id)
        {
            Product CurrentProduct = new Product();
            CurrentProduct = Context.Products.Where(x => x.Id == id).FirstOrDefault();
            return View(CurrentProduct);

        }
    }
}

