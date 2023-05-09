using System;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.E_Commerce.Models;
using MVC.E_Commerce.Models.ViewModel;

namespace MVC.E_Commerce.Controllers
{
	public class StoreSupportController : Controller
	{
		private readonly ApplicationContext Context;
		public StoreSupportController(ApplicationContext context)
		{
			Context = context;
		}
		public IActionResult Index()
		{
			List<Support> AllTickets = Context.Supports.ToList();
			return View(AllTickets);
		}


		//[HttpPost]
		public IActionResult ReplyTicket(int Id, string ReplyTicket , string StoreReply)
		{
			Support CurrentTicket = Context.Supports.FirstOrDefault(x => x.Id == Id);
			
			StoreSupport storeSupport = new StoreSupport();
			
			//storeSupport.Id = Id;
			storeSupport.StoreReply = ReplyTicket;
		
			
	
			return View (CurrentTicket);


		


			//return RedirectToAction(nameof(Index));
			

		


		}

		public IActionResult AnswerTicket ()
		{
			
			 return View();
		}
		[HttpPost]
		public IActionResult AnswerTicket ( int Id ,int TicketId, string StoreReply)
		{
			Support support = Context.Supports.FirstOrDefault(x => x.Id==Id);
			StSups storesupps = new StSups();
			storesupps.StoreReply = StoreReply;
			Context.Add(storesupps);
			Context.SaveChanges();
		



			/*

			Console.WriteLine(TicketId);
			Console.WriteLine(support);
			//storeSupport.TicketId = TicketId;
			storeSupport.StoreReply = StoreReply;
			//storeSupport.Supports.Add(support);
			Context.Add(storeSupport);
			Context.SaveChanges();
		*/

			return RedirectToAction(nameof(Index));
		}





		public IActionResult DeleteTicket(int Id)
		{
			Support Ticket = Context.Supports.FirstOrDefault(x => x.Id == Id);
			return View(Ticket);
		}
		public IActionResult DeleteConfirm(int Id)
		{
			Support Ticket = Context.Supports.FirstOrDefault(x => x.Id == Id);
			Context.Supports.Remove(Ticket);
			Context.SaveChanges();
			return RedirectToAction(nameof(Index));
		}

		public IActionResult EditTicket(int Id)
		{
			Support Ticket = Context.Supports.FirstOrDefault(x => x.Id == Id);
			return View(Ticket);
		}










	}
}
