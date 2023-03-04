using System.ComponentModel.DataAnnotations.Schema;

namespace SeoPieShop.Models
{
	public class OrderDetail
	{
		public int OrderDetailId { get; set; }
		public int Amount { get; set; }
		public decimal Price { get; set; }
		public int OrderId { get; set; }
		public int PieId { get; set; }
		[ForeignKey("OrderId")]
		public Order Order { get; set; }
		public Pie Pie { get; set; }
	}
}
