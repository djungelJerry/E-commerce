namespace MVC.E_Commerce.Models
{
	public class Support
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string Creator { get; set; }
		public List<StoreSupport> StoreSupports { get; set; }
	}
}
