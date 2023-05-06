using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_P_ASP.NET.Data.Models
{
    public class Flower
    {
        public int id { set; get; }
        public string name { set; get; }
        public string desc { set; get; }
        public string img { set; get; }
        public ushort price { set; get; }
        public bool isFavoirite { set; get; }
        public uint quantity { set; get; }
        public int categoryId { set; get; }  // категорія товару
        public virtual Category Category { set; get; } // об'єкт, що містить всю інформацію про категорію
    }
}
