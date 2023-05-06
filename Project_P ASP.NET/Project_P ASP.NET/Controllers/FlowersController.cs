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
    public class FlowersController : Controller
    {
        private readonly IAllFlowers _allFlowers;
        private readonly IFlowersCategory _allCategories;

        public FlowersController(IAllFlowers iAllFlowers, IFlowersCategory iFlowersCat)
        {
            _allFlowers = iAllFlowers;
            _allCategories = iFlowersCat;
        }

        [Route("Flowers/List")]
        [Route("Flowers/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Flower> flowers = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                flowers = _allFlowers.Flowers.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("HomePlants", category, StringComparison.OrdinalIgnoreCase))
                {
                    flowers = _allFlowers.Flowers.Where(i => i.Category.categoryName.Equals("Кімнатні рослини")).OrderBy(i => i.id);
                    currCategory = "Кімнатні рослини";
                }
                if (string.Equals("Dates", category, StringComparison.OrdinalIgnoreCase))
                {
                    flowers = _allFlowers.Flowers.Where(i => i.Category.categoryName.Equals("Для побачень")).OrderBy(i => i.id);
                    currCategory = "Квіти для побачень";
                }
                if (string.Equals("Garden", category, StringComparison.OrdinalIgnoreCase))
                {
                    flowers = _allFlowers.Flowers.Where(i => i.Category.categoryName.Equals("Садові рослини")).OrderBy(i => i.id);
                    currCategory = "Садові рослини";
                }
            }

            var flowerObj = new FlowersListViewModel
            {
                allFlowers = flowers,
                currCategory = currCategory
            };

            ViewBag.Title = "Сторінка з квітами";
            FlowersListViewModel obj = new FlowersListViewModel();
            obj.allFlowers = _allFlowers.Flowers;
            obj.currCategory = "Квіти";
            return View(flowerObj);
        }
        /*public ViewResult ListDates()
        {
            ViewBag.Title = "Сторінка з квітами для побачень";
            FlowersListViewModel obj = new FlowersListViewModel();
            obj.allFlowers = _allFlowers.Flowers;
            obj.currCategory = "Квіти";
            return View(obj);
        }*/

    }
}
