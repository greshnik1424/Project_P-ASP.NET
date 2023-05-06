using Project_P_ASP.NET.Data.Interfaces;
using Project_P_ASP.NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_P_ASP.NET.Data.Mocks
{
    public class MockFlowers : IAllFlowers
    {
        private readonly IFlowersCategory _categoryFlowers = new MockCategory();
        public IEnumerable<Flower> Flowers
        {
            get
            {
                return new List<Flower>
                {
                    new Flower {
                        name = "Алое",
                        desc = "Багаторічна тропічна та субстропічна рослина",
                        img = "/img/aloe.jpg",
                        price = 100,
                        isFavoirite = true,
                        quantity = 10,
                        Category = _categoryFlowers.AllCategories.First()
                    },
                    new Flower {
                        name = "Троянда",
                        desc = "Троянди в букеті виражають почуття захоплення, пристрасті, поваги",
                        img = "/img/troyanda.jpeg",
                        price = 30,
                        isFavoirite = false,
                        quantity = 300,
                        Category = _categoryFlowers.AllCategories.ElementAt(1)
                    },
                    new Flower {
                        name = "Маргаритка",
                        desc = "Невеликий розмір з коротким корнем",
                        img = "/img/daisy.jpg",
                        price = 120,
                        isFavoirite = false,
                        quantity = 24,
                        Category = _categoryFlowers.AllCategories.Last()
                    },
                    new Flower {
                        name = "Фасоль",
                        desc = "Трав'яна рослина з білими, червоними або фіолетовими квітами",
                        img = "/img/fasol.jpg",
                        price = 70,
                        isFavoirite = true,
                        quantity = 0,
                        Category = _categoryFlowers.AllCategories.Last()
                    },
                    new Flower {
                        name = "Хризантеми",
                        desc = "Справжня королева осені",
                        img = "/img/khrizantema.jpg",
                        price = 35,
                        isFavoirite = false,
                        quantity = 120,
                        Category = _categoryFlowers.AllCategories.ElementAt(1)
                    }
                };
            }
        }

        public IEnumerable<Flower> getFavFlowers { get; set; }

        public Flower getObjectCar(int flowerId)
        {
            throw new NotImplementedException();
        }
    }
}
