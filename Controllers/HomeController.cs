using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Caldo.Models;
using Caldo.Interfaces;
using Caldo.ViewModel;

namespace Caldo.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPizzaRepo _pizzaRepo;


        public HomeController(IPizzaRepo pizzaRepo )
        {
            _pizzaRepo  = pizzaRepo;
        }

        public IActionResult Index()
        {
            var homeViewModel = new HomeViewModel {
                PizzasOfTheWeek = _pizzaRepo.PizzasOfTheWeek
            };
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
