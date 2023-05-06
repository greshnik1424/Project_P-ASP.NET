using Microsoft.AspNetCore.Mvc;
using Project_P_ASP.NET.Data.Interfaces;
using Project_P_ASP.NET.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_P_ASP.NET.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllFlowers _flowerRep;
        public HomeController(IAllFlowers carRep)
        {
            _flowerRep = carRep;
        }
        public ViewResult Index()
        {
            var homeCars = new HomeViewModel
            {
                favFlowers = _flowerRep.getFavFlowers
            };
        return View(homeCars);
        }
    }
}