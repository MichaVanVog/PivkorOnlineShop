using System;
using System.Collections.Generic;
using System.Linq;
using PivkorOnlineShop.Models;

namespace PivkorOnlineShop
{
    public class OrdersInMemoryRepository : IOrdersInMemoryRepository
    {
        private List<Order> orders = new();


        public void Add(Order order)
        {
            orders.Add(order);
        }

        public List<Order> GetAllOrders()
        {
            return orders;  
        }

        public Order TryGetById(Guid orderId)
        {
            return orders.FirstOrDefault(x => x.Id == orderId);
        }

        public void UpdateOrderStatus(Guid orderId, OrderStatus newOrderStatus)
        {
            var order = TryGetById(orderId);
            if (order != null)
            {
                order.Status = newOrderStatus;
            }
        }
    }
}