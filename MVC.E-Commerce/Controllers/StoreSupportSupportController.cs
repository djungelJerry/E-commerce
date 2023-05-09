using System.Dynamic;
using Microsoft.AspNetCore.Mvc;
using MVC.E_Commerce.Migrations;
using MVC.E_Commerce.Models;

namespace MVC.E_Commerce.Controllers
{
	public class StoreSupportSupportController : Controller
	{
		private readonly ApplicationContext Context;
		public StoreSupportSupportController(ApplicationContext context)
		{
			Context = context;
		}
		public IActionResult DisplayAnswers(Support Supports, StoreSupport StoreSupports)
		{
			//ViewBag.Message = "Welcome to my demo!";
			//dynamic mymodel = new ExpandoObject();
			//mymodel.Supports = new support();
			//mymodel.StoreSupports = new storesupp();
			return View();
		}
	}
}