using Project_P_ASP.NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_P_ASP.NET.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Flower> favFlowers { get; set; }
    }
}