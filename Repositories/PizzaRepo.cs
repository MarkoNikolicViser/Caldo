using Caldo.Interfaces;
using Caldo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caldo.Repositories
{

    public class PizzaRepo : IPizzaRepo
    {
        private readonly AppDbContext _appDbContext;

        public PizzaRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Pizza> Pizzas
        {
            get
            {
                return _appDbContext.Pizza.Include(c => c.Category);
            }
        }

        public IEnumerable<Pizza> PizzasOfTheWeek
        {
            get
            {
                return _appDbContext.Pizza.Include(c => c.Category).Where(p => p.Najprodavanija);
            }
        }

        public Pizza GetPizzaById(int pizzaId)
        {
            return _appDbContext.Pizza.FirstOrDefault(p => p.PizzaId == pizzaId);
        }
    }
}
