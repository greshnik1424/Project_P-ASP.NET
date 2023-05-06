using Project_P_ASP.NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_P_ASP.NET.Data.Interfaces
{
    public interface IFlowersCategory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
