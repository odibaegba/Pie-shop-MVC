﻿using Microsoft.AspNetCore.Mvc;
using SeoPieShop.Models;
using SeoPieShop.ViewModels;

namespace SeoPieShop.Components
{
	public class ShoppingCartSummary : ViewComponent
	{
		private readonly ShoppingCart _shoppingCart;

		public ShoppingCartSummary(ShoppingCart shoppingCart)
		{
			_shoppingCart = shoppingCart;
		}

		public IViewComponentResult Invoke()
		{
			var item = _shoppingCart.GetShoppingCartItems();
			_shoppingCart.ShoppingCartItems = item;

			var shoppingCartViewModel = new ShoppingCartViewModel
			{
				ShoppingCart = _shoppingCart,
				ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal(),
			};
			return View(shoppingCartViewModel);
		}
	}
}
