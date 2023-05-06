using Project_P_ASP.NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_P_ASP.NET.ViewModels
{
    public class FlowersListViewModel
    {
        //поле, що зберігає всі квіти
        public IEnumerable<Flower> allFlowers { get; set; }
        //поле, що зберігає поточну категорію
        public string currCategory { get; set; }
    }
}
