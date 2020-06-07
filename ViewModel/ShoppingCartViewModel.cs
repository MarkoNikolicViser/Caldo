using Caldo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caldo.ViewModel
{
    public class ShoppingCartViewModel
    {
        public ShoppingCart  ShoppingCart { get; set; }
        public decimal ShoppingCartTotal { get; set; }
    }
}
