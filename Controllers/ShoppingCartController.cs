using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineCakeShop.Model;

namespace OnlineCakeShop.Controllers
{
    public class ShoppingCartController : Controller
    {

        private readonly IPieRepository _pieRepository;
        private readonly ShoppingCart _shoppingCart;

        public ShoppingCartController(IPieRepository pieRepository, ShoppingCart shoppingCart)
        {
            _pieRepository = pieRepository;
            _shoppingCart = shoppingCart;

        }
        public IActionResult Index()
        {

            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModel = new ShoppingCartViewModel
            {
                ShoppingCart = _shoppingCart,
                ShoppingCartTotal = _shoppingCart.GetShoppingCartTotal()
            };
            return View(shoppingCartViewModel);
        }

        public RedirectToActionResult addToShoppingCart(int pieId)
        {
            var selectedPie = _pieRepository.AllPies.FirstOrDefault(s => s.PieId == pieId);
            if (selectedPie != null)
                _shoppingCart.AddToCart(selectedPie, 1);

            
            return RedirectToAction("Index");
        }

        public RedirectToActionResult removeFromShoppingCart(int pieId)
        {
            var selectedPie = _pieRepository.AllPies.FirstOrDefault(s => s.PieId == pieId);
            if (selectedPie != null)
                _shoppingCart.RemoveFromCart(selectedPie);


            return RedirectToAction("Index");
        }
    }
}