using Project_P_ASP.NET.Data.Interfaces;
using Project_P_ASP.NET.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_P_ASP.NET.Data.Repository
{
    public class OrdersRepository : IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly Cart shopCart;
        public OrdersRepository(AppDBContent appDBContent, Cart shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }
        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();
            var items = shopCart.listItems;
            foreach (var el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    flowerID = el.flower.id,
                    orderID = order.id,
                    price = el.flower.price
                };
                appDBContent.OrderDetail.Add(orderDetail);
            }
        appDBContent.SaveChanges();
        }
    }
}
