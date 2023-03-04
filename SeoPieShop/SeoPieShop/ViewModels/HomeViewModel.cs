using SeoPieShop.Models;
using System.Collections.Generic;

namespace SeoPieShop.ViewModels
{
	public class HomeViewModel
	{
		public IEnumerable<Pie> PiesOfTheWeek { get; set; }
	}
}
