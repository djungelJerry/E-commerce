using Microsoft.AspNetCore.Mvc;

namespace MVC.E_Commerce.Controllers
{
    public class TagsController : Controller
    {
        private readonly ApplicationContext Context;

        public TagsController(ApplicationContext _context)
        {
            Context = _context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
