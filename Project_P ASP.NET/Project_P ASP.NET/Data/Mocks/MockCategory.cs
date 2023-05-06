using Project_P_ASP.NET.Data.Interfaces;
using Project_P_ASP.NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_P_ASP.NET.Data.Mocks
{
    public class MockCategory : IFlowersCategory
    {
        public IEnumerable<Category> AllCategories
        {
            get 
            {
                return new List<Category>
                {
                    new Category { categoryName = "Кімнатні рослини", desc = "Квіти та рослини, що використовують для декору та затишку в домі"},
                    new Category { categoryName = "Для побачень", desc = "Квіти, які ви можете подарувати вашій коханій людині "},
                    new Category { categoryName = "Садові рослини", desc = "Квіти та рослини, що ви можете вирощувати в саду"}
                };
            }
        }
    }
}
