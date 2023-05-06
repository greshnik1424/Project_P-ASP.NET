using Microsoft.AspNetCore.Mvc;
using Project_P_ASP.NET.Data.Interfaces;
using Project_P_ASP.NET.Data.Models;
using Project_P_ASP.NET.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_P_ASP.NET.Controllers
{
    public class CartController : Controller
    {
        private readonly IAllFlowers _flowerRep;
        private readonly Cart _cart;
        public CartController(IAllFlowers flowerRep, Cart shopCart)
        {
            _flowerRep = flowerRep;
            _cart = shopCart;
        }
        public ViewResult Index()
        {
            var items = _cart.getItems();
            _cart.listItems = items;
            var obj = new CartViewModel
            {
                cart = _cart
            };
            return View(obj);
        }
        public RedirectToActionResult AddToCart(int id)
        {
            var item = _flowerRep.Flowers.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _cart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
