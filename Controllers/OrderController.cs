using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Caldo.Interfaces;
using Caldo.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Caldo.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderRepo _orderRepo;
        private readonly ShoppingCart _shoppingCart;

        public OrderController(IOrderRepo orderRepo, ShoppingCart shoppingCart)
        {
            _orderRepo = orderRepo;
            _shoppingCart = shoppingCart;

        }
        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }
        [Authorize]
        [HttpPost]
        public IActionResult Checkout(Order order) {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;
            if (_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your cart is empty, add some pizzas first");
            }

            if (ModelState.IsValid)
            {
                _orderRepo.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);  //else
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Hvala sto ste jeli kod nas";
            return View();
        }
    }
}
