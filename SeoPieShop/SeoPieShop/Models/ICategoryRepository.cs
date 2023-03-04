using System.Collections.Generic;

namespace SeoPieShop.Models
{
	public interface ICategoryRepository
	{
		IEnumerable<Category> AllCategories { get; }
	}
}
