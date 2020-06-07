using Caldo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caldo.Interfaces
{
    public interface ICategoryRepo
    {
        IEnumerable<Category> Categories { get; }

    }
}
