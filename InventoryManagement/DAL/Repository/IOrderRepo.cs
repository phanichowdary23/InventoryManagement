using InventoryManagement.DAL.Models;
using System.Collections.Generic;

namespace InventoryManagement.DAL.Repository
{
    public interface IOrderRepo
    {
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int orderId);
        Order GetOrderById(int orderId);
        List<Order> GetAllOrders();
    }
}
