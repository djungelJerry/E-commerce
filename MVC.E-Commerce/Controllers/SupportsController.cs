using Microsoft.AspNetCore.Mvc;
using MVC.E_Commerce.Models;
//using System.Net.Sockets;


using MVC.E_Commerce;
using System.Net.Sockets;
using MVC.E_Commerce.Migrations;
using System.Runtime.CompilerServices;
using Microsoft.Identity.Client;
using System.Dynamic;
using MVC.E_Commerce.Models.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace MVC.E_Commerce.Controllers
{
	public class SupportController : Controller
	{
		private readonly ApplicationContext Context;
		public SupportController(ApplicationContext context)
		{
			Context = context;
		}
		public IActionResult Index()
		{
			List<Support> AllTickets = Context.Supports.ToList();
			return View(AllTickets);
		}
		public IActionResult CreateTicket()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateTicket(string Title, string Description, string Creator)
		{
			StoreSupport Reply = new StoreSupport();
			Support NewTicket = new Support();
			NewTicket.Title = Title;
			NewTicket.Description = Description;
			NewTicket.Creator = Creator;
			Context.Supports.Add(NewTicket);
			Context.SaveChanges();

		
			
			return RedirectToAction(nameof(Index));
		}
        /*
		public IActionResult DetailsTicket (int TicketId)
		{
			//StoreSupport Ticket = Context.StoreSupports.Include( x => x.Supports).FirstOrDefault(x => x.Id == Id);

			Support Ticket = Context.StoreSupports.Include(t => t.StoreReply).FirstOrDefault(t => t.Id == TicketId);

          //  Ticket CurrentTicket = Context.Tickets.Include(t => t.TicketMessages).FirstOrDefault(t => t.Id == TicketId);

           // StoreSupport storeSupport = new StoreSupport();
			//StoreSupport store = Context.StoreSupports.FirstOrDefault(x => x.TicketId == TicketId);
			//storeSupport.TicketId = Id;
		//	storeSupport.StoreReply = StoreReply;
			//Context.Update(storeSupport);
			
			//.SaveChanges();
		
			

			return View(Ticket);
		}*/
		

		public IActionResult DetailsTicket(int Id)
		{
            Support CustomerTicket = Context.Supports.FirstOrDefault(c => c.Id == Id);
			

			return View(CustomerTicket);

		}

		public IActionResult PartialView()
		
			{
				ViewBag.Message = "Welcome to my demo!";
				return View();
			}

			/// <summary>
			/// Render Teacher List
			/// </summary>
			/// <returns></returns>
		//	public PartialViewResult RenderTeacher()
		//	{
		//		return PartialView(GetSupports());
		//	}

			/// <summary>
			/// Render Student List
			/// </summary>
			/// <returns></returns>
		//	public PartialViewResult RenderStudent()
		//	{
		//		return PartialView(GetStoreSupports());
		//	}
		

		public IActionResult displayanswers(Support Supports, StoreSupport StoreSupports)
		{
			ViewBag.Message = "Welcome to my demo!";
			dynamic mymodel = new ExpandoObject();
			mymodel.Supports = new support();
			mymodel.StoreSupports = new storesupp();
			return View(mymodel);
		}

		/*	public IActionResult DetailsTicket(int Id , string StoreReply)
			{

				//System.Diagnostics.Debug.WriteLine("Id: " + Id);

				Support Ticket = Context.Supports.FirstOrDefault(x => x.Id == Id );
			//	StoreSupport Store = Context.StoreSupports.FirstOrDefault(y => y.Id);
				StoreSupport storeSupport = new StoreSupport();
				storeSupport.Supports = new List<Support>();
				storeSupport.StoreReply = StoreReply;

				//storeSupport support = new List<Support> { support };
				return View(Ticket + StoreReply);

			}*/

        public IActionResult EditTicket(int Id)
		{
			Support Ticket = Context.Supports.FirstOrDefault(x => x.Id == Id);
			return View(Ticket);
		}
		[HttpPost]
		public IActionResult EditTicket(int Id, string Title, string Description, string Creator)
		{
			Support Ticket = Context.Supports.FirstOrDefault(x => x.Id == Id);
			Ticket.Title = Title;
			Ticket.Description = Description;
			Ticket.Creator = Creator;
			//Ticket.Reply = Reply;
			Context.Supports.Update(Ticket);
			Context.SaveChanges();
			return RedirectToAction(nameof(Index));
		}

		/*
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
		}*/
	}
}
