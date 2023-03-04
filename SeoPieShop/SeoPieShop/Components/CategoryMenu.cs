using Microsoft.AspNetCore.Mvc;
using SeoPieShop.Models;
using System.Linq;

namespace SeoPieShop.Components
{
	public class CategoryMenu : ViewComponent
	{
		private ICategoryRepository _categoryRepository;

		public CategoryMenu(ICategoryRepository categoryRepository)
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
