using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SeoPieShop.Models
{
	public class Order
	{
		public int OrderId { get; set; }
		public List<OrderDetail> OrderDetails { get; set; }

		[Required(ErrorMessage = "Please enter first name")]
		[Display(Name = "First Name")]
		[StringLength(50)]
		public string FirstName { get; set; }

		[Required(ErrorMessage = "Please enter last name")]
		[Display(Name = "Last Name")]
		[StringLength(50)]
		public string LastName { get; set; }

		[Required(ErrorMessage = "Please enter your address")]
		[Display(Name = "Address Line 1")]
		[StringLength(100)]
		public string AddressLine1 { get; set; }

		[Display(Name = "Address Line 2")]
		public string AddressLine2 { get; set; }

		[Required(ErrorMessage = "Please enter your zip code")]
		[Display(Name = "Zip code")]
		[StringLength(10, MinimumLength = 4)]
		public string ZipCode { get; set; }

		[Required(ErrorMessage = "Please enter Your City")]
		[StringLength(50)]
		public string City { get; set; }

		[StringLength(20)]
		public string State { get; set; }

		[Required(ErrorMessage = "Please enter your country")]
		[StringLength(50)]
		public string Country { get; set; }

		[Required(ErrorMessage = "Please enter your phone number")]
		[StringLength(25)]
		[DataType(DataType.PhoneNumber)]
		[Display(Name = "Phone Number")]
		public string PhoneNumber { get; set; }

		[Required]
		[StringLength(50)]
		[DataType(DataType.EmailAddress)]
		[RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
		 ErrorMessage = "Please enter a valid email.")]
		public string Email { get; set; }

		[BindNever]
		[ScaffoldColumn(false)]
		public decimal OrderTotal { get; set; }

		[BindNever]
		[ScaffoldColumn(false)]
		public DateTime OrderPlaced { get; set; }
	}
}
