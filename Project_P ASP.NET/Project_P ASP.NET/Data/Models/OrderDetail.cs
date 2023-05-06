using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_P_ASP.NET.Data.Models
{
    public class OrderDetail
    {
        public int id { get; set; }
        public int orderID { get; set; }
        public int flowerID { get; set; }
        public uint price { get; set; }
        public virtual Flower flowers { get; set; }
        public virtual Order order { get; set; }
    }
}