using SeoPieShop.Models;
using System.Collections.Generic;

namespace SeoPieShop.ViewModels
{
	public class PiesListViewModel
	{
		public IEnumerable<Pie> Pies { get; set; }
		public string CurrentCategory { get; set; }
	}
}
