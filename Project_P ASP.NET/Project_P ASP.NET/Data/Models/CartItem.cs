using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_P_ASP.NET.Data.Models
{
    public class CartItem
    {
        public int id { get; set; }//id самого товару
        public Flower flower { get; set; }
        public int price { get; set; }
        public string CartId { get; set; }//id товару в кошику
    }
}