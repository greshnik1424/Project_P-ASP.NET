using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_P_ASP.NET.Data.Models
{
    public class Category
    {
        public int id { set; get; }
        public string categoryName { set; get; }
        public string  desc { set; get; }
        public List<Flower> flowers { set; get; } // список товарів в категорії
    }
}
