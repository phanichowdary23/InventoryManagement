using InventoryManagement.BLL.DTOs;

namespace InventoryManagement.BLL.Service
{
    public interface IOrderService
    {
        public IEnumerable<OrderDTO> GetAllOrders();
        public OrderDTO GetOrderById(int orderId);
        void AddOrder(OrderDTO orderDTO);
        void UpdateOrder(OrderDTO orderDTO);
        void DeleteOrder(int orderId);
    }
}
