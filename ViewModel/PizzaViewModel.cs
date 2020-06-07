using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caldo.ViewModel
{
    public class PizzaViewModel
    {
        public int PizzaId { get; set; }
        public string Ime { get; set; }
        public string MaliOpis { get; set; }
        public decimal Cena { get; set; }
        public string SlikaThumbUrl { get; set; }
    }
}
