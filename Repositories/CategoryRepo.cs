using Caldo.Interfaces;
using Caldo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caldo.Repositories
{
    public class CategoryRepo : ICategoryRepo
    {
        
            private readonly AppDbContext _appDbContext;
        public CategoryRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> Categories => _appDbContext.Category;  
        
           
        
        
        
    }
}
