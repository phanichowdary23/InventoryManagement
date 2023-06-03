using InventoryManagement.DAL.Models;

namespace InventoryManagement.BLL.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public static implicit operator OrderDTO(Order order)
        {
            if (order == null) return null;
            return new OrderDTO
            {
                Id = order.Id,
                ProductId = order.ProductId,
                OrderDate = order.OrderDate,
                Quantity = order.Quantity,
                TotalPrice = order.TotalPrice
            };
        }

        public static explicit operator Order(OrderDTO orderDTO)
        {
            if (orderDTO == null) return null;
            return new Order
            {
                Id = orderDTO.Id,
                ProductId = orderDTO.ProductId,
                OrderDate = orderDTO.OrderDate,
                Quantity = orderDTO.Quantity,
                TotalPrice = orderDTO.TotalPrice
            };
        }
    }
}
