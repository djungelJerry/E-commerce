namespace MVC.E_Commerce.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public decimal CartTotal { get; set; }
        public List<CartItem> CartItems { get; set;}
    }
}
