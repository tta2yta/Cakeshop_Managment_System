using Microsoft.AspNetCore.Mvc;
using OnlineCakeShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineCakeShop.Components
{
    public class CategoryMenu : ViewComponent
    {

        private readonly ICategoryRepository _categoryRepository;

        public CategoryMenu( ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.AllCategories.OrderBy(c => c.CategoryName);
            return View(categories);
        }
    }
}
