using InventoryManagement.BLL.DTOs;
using InventoryManagement.DAL.Models;
using InventoryManagement.DAL.Repository;

namespace InventoryManagement.BLL.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepo _orderRepository;

        public OrderService(IOrderRepo orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IEnumerable<OrderDTO> GetAllOrders()
        {
            var orders = _orderRepository.GetAllOrders();
            return orders.Select(o => (OrderDTO)o).ToList();
        }

        public OrderDTO GetOrderById(int orderId)
        {
            var order = _orderRepository.GetOrderById(orderId);
            return (OrderDTO)order;
        }

        public void AddOrder(OrderDTO orderDTO)
        {
            var order = (Order)orderDTO;
            _orderRepository.AddOrder(order);
        }

        public void UpdateOrder(OrderDTO orderDTO)
        {
            var order = (Order)orderDTO;
            _orderRepository.UpdateOrder(order);
        }

        public void DeleteOrder(int orderId)
        {
            var order = _orderRepository.GetOrderById(orderId);
            if (order != null)
            {
                _orderRepository.DeleteOrder(order);
            }
        }
    }
}
