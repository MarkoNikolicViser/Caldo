using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Caldo.Interfaces;
using Caldo.Models;

namespace Caldo.Repositories
{
    public class MockPizzaRepo : IPizzaRepo
    {
        private readonly ICategoryRepo _categoryRepo = new MockCategoryRepo();
        public IEnumerable<Pizza> Pizzas {
            get {
                return new List<Pizza>
                {
                new Pizza {PizzaId=1, Ime="Capricciosa", Cena=400, MaliOpis="Pica sa sunkom, pecurkama i kackavaljem",
                    VelikiOpis="Odlicna pica za male pare kida bajo, ko jos ne voli ovakvu picu",Category=_categoryRepo.Categories.ToList()[0], SlikaUrl="/Images/Menu/pica1.jpg", NaStanju=true, Najprodavanija=true, SlikaThumbUrl ="/Images/MenuThumb/pica1mala.jpg" },
                new Pizza {PizzaId = 2, Ime="Fresh Basil pizza", Cena=15.95M, MaliOpis="Grilled Tomato-Peach Pizza",
                        VelikiOpis ="Regardless what else comes atop your pizza, a few fresh basil leaves will taste amazing with it. This simple summertime pizza would make a delicious cookout appetizer or light dinner paired with a salad.", Category = _categoryRepo.Categories.ToList()[0],SlikaUrl="/Images/Menu/pica1.jpg", NaStanju=true, Najprodavanija=false, SlikaThumbUrl="/Images/MenuThumb/pica1mala.jpg"}

                };
               }
        }

        public IEnumerable<Pizza> PizzasOfTheWeek => throw new NotImplementedException();

        public Pizza GetPizzaById(int pizzaId)
        {
            throw new NotImplementedException();
        }
    }
}
