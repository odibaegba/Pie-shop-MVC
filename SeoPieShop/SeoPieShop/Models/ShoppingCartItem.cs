using System.ComponentModel.DataAnnotations;

namespace SeoPieShop.Models
{
	public class ShoppingCartItem
	{
		[Key]
		public int ShoppingCardItemId { get; set; }
		public Pie Pie { get; set; }
		public int Amount { get; set; }
		public string ShoppingCartId { get; set; }
	}
}
