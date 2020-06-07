using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Caldo.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Caldo.ViewModel;
using Caldo.Models;

namespace Caldo.Controllers
{
    public class PizzaController : Controller
    {
        private readonly ICategoryRepo _categoryRepo;
        private readonly IPizzaRepo _pizzaRepo;

        public PizzaController(IPizzaRepo pizzaRepo,ICategoryRepo categoryRepo )
        {
            _pizzaRepo = pizzaRepo;
            _categoryRepo = categoryRepo;
        }
        public ViewResult List(string category)
        {
            IEnumerable<Pizza> pizzas;
            string currentCategory = string.Empty;

            if (string.IsNullOrEmpty(category))
            {
                pizzas = _pizzaRepo.Pizzas.OrderBy(p => p.PizzaId);
                currentCategory = "All pizzas";
            }
            else
            {
                pizzas = _pizzaRepo.Pizzas.Where(p => p.Category.CategoryName == category)
                   .OrderBy(p => p.PizzaId);
                currentCategory = _categoryRepo.Categories.FirstOrDefault(c => c.CategoryName == category).CategoryName;
            }

            return View(new PizzaListViewModel
            {
                Pizzas = pizzas,
                CurrentCategory = currentCategory
            });
        }


        public IActionResult Details(int id)
        {
            var pizza = _pizzaRepo.GetPizzaById(id);
            if (pizza == null)
                return NotFound();

            return View(pizza);
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}