using Microsoft.EntityFrameworkCore;
using Project_P_ASP.NET.Data.Interfaces;
using Project_P_ASP.NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_P_ASP.NET.Data.Repository
{
    public class FlowerRepository : IAllFlowers
    {
        //змінна для роботи з класом налаштувань БД AppDBContext.cs
        private readonly AppDBContent appDBContent;
        public FlowerRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Flower> Flowers => appDBContent.Flower.Include(c => c.Category);

        public IEnumerable<Flower> getFavFlowers => appDBContent.Flower.Where(p => p.isFavoirite).Include(c => c.Category);

        public Flower getObjectCar(int flowerId) => appDBContent.Flower.FirstOrDefault(p => p.id == flowerId);
    }
}
