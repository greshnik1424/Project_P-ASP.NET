using Project_P_ASP.NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_P_ASP.NET.Data.Interfaces
{
    public interface IAllFlowers
    {
        //функція повертає всі товари
        IEnumerable<Flower> Flowers { get; }
        //функція повертає всі товари у яких isFavorite = true
        IEnumerable<Flower> getFavFlowers { get;}
        //повертає товар за його id
        Flower getObjectCar(int flowerId);
    }
}
