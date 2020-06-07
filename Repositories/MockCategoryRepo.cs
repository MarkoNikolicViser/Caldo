using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Caldo.Interfaces;
using Caldo.Models;

namespace Caldo.Repositories
{
    public class MockCategoryRepo : ICategoryRepo
    {
        public IEnumerable<Category> Categories {
            get {
                return new List<Category> {

                new Category{CategoryId=1, CategoryName="Vegan pizza", Description="Short descripton" },
                new Category{CategoryId=2, CategoryName="Sunka pizza", Description="Short descripton" },
                new Category{CategoryId=3, CategoryName="Kobaja pizza", Description="Short descripton" }



                };






            }
        
        
        
        }
    }
}
//15:23     