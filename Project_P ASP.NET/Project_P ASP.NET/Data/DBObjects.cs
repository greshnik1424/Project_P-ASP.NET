using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Project_P_ASP.NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_P_ASP.NET.Data
{
    public class DBObjects
    {
        //функція для підключення до БД
        public static void Initial(AppDBContent content)
        {
            //якщо не має жодної категорії, то додаємо категорії
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            //якщо не має жодного товару, то додаємо товар
            if (!content.Flower.Any())
            {
                content.AddRange(
                    new Flower
                    {
                        name = "Алое",
                        desc = "Багаторічна тропічна та субстропічна рослина",
                        img = "/img/aloe.jpg",
                        price = 100,
                        isFavoirite = true,
                        quantity = 10,
                        Category = Categories["Кімнатні рослини"]
                    },
                    new Flower
                    {
                        name = "Троянда",
                        desc = "Троянди в букеті виражають почуття захоплення, пристрасті, поваги",
                        img = "/img/troyanda.jpeg",
                        price = 30,
                        isFavoirite = false,
                        quantity = 300,
                        Category = Categories["Для побачень"]
                    },
                    new Flower
                    {
                        name = "Маргаритка",
                        desc = "Невеликий розмір з коротким корнем",
                        img = "/img/daisy.jpg",
                        price = 120,
                        isFavoirite = false,
                        quantity = 24,
                        Category = Categories["Садові рослини"]
                    },
                    new Flower
                    {
                        name = "Фасоль",
                        desc = "Трав'яна рослина з білими, червоними або фіолетовими квітами",
                        img = "/img/fasol.jpg",
                        price = 70,
                        isFavoirite = true,
                        quantity = 0,
                        Category = Categories["Садові рослини"]
                    },
                    new Flower
                    {
                        name = "Хризантеми",
                        desc = "Справжня королева осені",
                        img = "/img/khrizantema.jpg",
                        price = 35,
                        isFavoirite = false,
                        quantity = 120,
                        Category = Categories["Для побачень"]
                    }

                    );
            }
            content.SaveChanges();
        }

        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                    new Category { categoryName = "Кімнатні рослини", desc = "Квіти та рослини, що використовують для декору та затишку в домі"},
                    new Category { categoryName = "Для побачень", desc = "Квіти, які ви можете подарувати вашій коханій людині "},
                    new Category { categoryName = "Садові рослини", desc = "Квіти та рослини, що ви можете вирощувати в саду"}
                    };

                    category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }
        }
        
    }
}