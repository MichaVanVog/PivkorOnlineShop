using System;
using System.Collections.Generic;
using PivkorOnlineShop.Models;

namespace PivkorOnlineShop
{
    public interface IOrdersInMemoryRepository
    {
        void Add(Order order);
        List<Order> GetAllOrders();
        Order TryGetById(Guid orderId);
        void UpdateOrderStatus(Guid orderId, OrderStatus newOrderStatus);
    }
}