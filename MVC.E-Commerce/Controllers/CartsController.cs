using Microsoft.AspNetCore.Mvc;

namespace MVC.E_Commerce.Controllers
{
    public class CartsController : Controller
    {
        private readonly ApplicationContext Context;

        public CartsController(ApplicationContext _context)
        {
            Context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
