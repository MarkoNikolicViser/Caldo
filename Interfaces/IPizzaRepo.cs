using Caldo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caldo.Interfaces
{
    public interface IPizzaRepo
    {
        IEnumerable<Pizza> Pizzas { get; }
        IEnumerable<Pizza> PizzasOfTheWeek { get; }

        Pizza GetPizzaById(int pizzaId);
    }
}
