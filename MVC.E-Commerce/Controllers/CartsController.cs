using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC.E_Commerce.Models;

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
        public IActionResult AddToCart(int id)
        {
            Product CurrentProduct = Context.Products.FirstOrDefault(x => x.Id == id);
            CartItem ExistingCartItem = Context.CartItems
                .FirstOrDefault(x => x.CartId == 1 && x.ProductId == CurrentProduct.Id);
            if (ExistingCartItem != null)
            {
                ExistingCartItem.Quantity = ExistingCartItem.Quantity + 1;
                ExistingCartItem.CartItemTotal = ExistingCartItem.CartItemTotal + CurrentProduct.ProductPrice;
                Context.CartItems.Update(ExistingCartItem);
                Cart Cart = Context.Carts.FirstOrDefault(x => x.Id == 1);
                Cart.CartTotal = Cart.CartTotal + CurrentProduct.ProductPrice;
                Context.SaveChanges();
            }
            else
            {
                CartItem CartItem = new CartItem();
                CartItem.ProductId = CurrentProduct.Id;
                CartItem.Quantity = 1;
                CartItem.CartItemTotal = CurrentProduct.ProductPrice;
                Cart Cart = Context.Carts.FirstOrDefault(x => x.Id == 1);
                Cart.CartTotal = Cart.CartTotal + CartItem.CartItemTotal;
                Cart.CartItems = new List<CartItem>();
                Cart.CartItems.Add(CartItem);
                Context.Carts.Update(Cart);
                Context.SaveChanges();
            }

            return RedirectToAction(nameof(Details));

        }

        public IActionResult Details()
        {
            Cart Cart = Context.Carts
                .Include(x => x.CartItems).FirstOrDefault(x => x.Id == 1);
            return View(Cart);
        }
    }
}
