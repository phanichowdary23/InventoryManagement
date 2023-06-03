using System.Collections.Generic;
using System.Linq;
using InventoryManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.DAL.Repository
{
    public class OrderRepo : IOrderRepo
    {
        private readonly AppDbContext _context;

        public OrderRepo(AppDbContext context)
        {
            _context = context;
        }

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void DeleteOrder(int orderId)
        {
            var order = _context.Orders.Find(orderId);
            _context.Orders.Remove(order);
            _context.SaveChanges();
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders
                .Include(o => o.Product)
                .Include(o => o.Customer)
                .FirstOrDefault(o => o.Id == orderId);
        }

        public List<Order> GetAllOrders()
        {
            return _context.Orders
                .Include(o => o.Product)
                .Include(o => o.Customer)
                .ToList();
        }

        public void DeleteOrder(Order order)
        {
            throw new NotImplementedException();
        }
    }
}