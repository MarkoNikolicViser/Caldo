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
    [Route("api/[controller]")]
    public class PizzaDataController : Controller
    {
        private readonly IPizzaRepo _pizzaRepo;
        public PizzaDataController(IPizzaRepo pizzaRepo)
        {
            _pizzaRepo = pizzaRepo;
        }

        [HttpGet]
        public IEnumerable<PizzaViewModel> LoadMorePizzas()
        {
            IEnumerable<Pizza> dbPizzas = null;

            dbPizzas = _pizzaRepo.Pizzas.OrderBy(p => p.PizzaId).Take(10);

            List<PizzaViewModel> pizzas = new List<PizzaViewModel>();

            foreach (var dbPizza in dbPizzas)
            {
                pizzas.Add(MapDbPieToPieViewModel(dbPizza));
            }

            return pizzas;
        }

        private PizzaViewModel MapDbPieToPieViewModel(Pizza dbPizza)
        {
            return new PizzaViewModel()
            {
                PizzaId = dbPizza.PizzaId,
                Ime = dbPizza.Ime,
                Cena = dbPizza.Cena,
                MaliOpis = dbPizza.MaliOpis,
                SlikaThumbUrl = dbPizza.SlikaThumbUrl
            };
        }
    }
}