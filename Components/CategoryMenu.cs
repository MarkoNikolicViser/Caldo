using Caldo.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Caldo.Components
{

        public class CategoryMenu : ViewComponent
        {
            private readonly ICategoryRepo _categoryRepo;
            public CategoryMenu(ICategoryRepo categoryRepo)
            {
                _categoryRepo = categoryRepo;
            }

            public IViewComponentResult Invoke()
            {
                var categories = _categoryRepo.Categories.OrderBy(c => c.CategoryName);
                return View(categories);
            }
        }
}
