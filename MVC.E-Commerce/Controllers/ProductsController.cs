using Microsoft.AspNetCore.Mvc;

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
            return View();
        }
    }
}
