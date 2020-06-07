using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Caldo.Interfaces;
using Caldo.Models;
using Caldo.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Caldo.Controllers
{
    public class ShoppingCartController : Controller
    {
        private readonly IPizzaRepo _pizzaRepo;
        private readonly ShoppingCart _shoppingCart;
        public ShoppingCartController(IPizzaRepo pizzaRepo,ShoppingCart shoppingCart )
        {
            _pizzaRepo = pizzaRepo;
            _shoppingCart = shoppingCart;
        }
        public ViewResult Index()
        {
            var items = _shoppingCart.GetShoppingCartItems();
        
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };

            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult AddToShoppingCart(int pizzaId)
        {
            var selectedPizza = _pizzaRepo.Pizzas.FirstOrDefault(p => p.PizzaId == pizzaId);

            if (selectedPizza != null)
            {
                _shoppingCart.AddToCart(selectedPizza, 1);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShoppingCart(int pizzaId)
        {
            var selectedPizza = _pizzaRepo.Pizzas.FirstOrDefault(p => p.PizzaId == pizzaId);

            if (selectedPizza != null)
            {
                _shoppingCart.RemoveFromCart(selectedPizza);
            }
            return RedirectToAction("Index");
        }
    }
}
    
