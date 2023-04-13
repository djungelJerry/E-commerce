using Microsoft.AspNetCore.Mvc;

namespace MVC.E_Commerce.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationContext Context;

        public CategoriesController(ApplicationContext _context)
        {
            Context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
