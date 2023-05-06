using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_P_ASP.NET.Data.Models
{
    public class Cart
    {
        //змінна для роботи з класом налаштувань БД AppDBContext.cs
        private readonly AppDBContent appDBContent;
        public Cart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string CartId { get; set; }
        public List<CartItem> listItems { get; set; }
        public static Cart GetCart(IServiceProvider services)
        {
            //створюємо об'єкт для роботи з сессією
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();
            //перевіряємо чи був створений кошик чи створюємо новий
            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString(); //id кошика
            //присваюємо id кошика сессії
            session.SetString("CartId", cartId);
            return new Cart(context) { CartId = cartId };
        }
        //функція додавання товару до кошика
        public void AddToCart(Flower flower)
        {
            appDBContent.CartItem.Add(new CartItem
            {
                CartId = CartId,
                flower = flower,
                price = flower.price
            });
            appDBContent.SaveChanges();
        }
        //функція відображення товарів в кошику
        public List<CartItem> getItems()
        {
            return appDBContent.CartItem.Where(c => c.CartId == CartId).Include(s => s.flower).ToList();
        }
    }
}
