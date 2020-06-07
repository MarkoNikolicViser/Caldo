using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Caldo.Models
{
    public class Pizza
    {
        [Key]
        public int PizzaId { get; set; }
        public string Ime { get; set; }
        public string MaliOpis { get; set; }
        public string VelikiOpis { get; set; }
        public decimal Cena { get; set; }
        public string SlikaUrl { get; set; }
        public string SlikaThumbUrl { get; set; }
        public bool Najprodavanija { get; set; }
        public bool NaStanju { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
