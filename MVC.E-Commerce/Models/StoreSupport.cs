namespace MVC.E_Commerce.Models
{
	public class StoreSupport
	{
		public int Id { get; set; }
		public int TicketId { get; set; }
		public string StoreReply { get; set; }
		public bool IsCustomer { get; set; }
		public Support Support { get; set; }
	}
}