using InventoryManagement.DAL.Models;

namespace InventoryManagement.BLL.DTOs
{
    public class ProductDTO
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int Stock { get; set; }

        public static implicit operator ProductDTO(Product product)
        {
            if (product == null) return null;
            return new ProductDTO
            {
                ProductId = product.ProductId,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Quantity = product.Quantity,
                Stock = product.Stock
            };
        }

        public static explicit operator Product(ProductDTO productDTO)
        {
            if (productDTO == null) return null;
            return new Product
            {
                ProductId = productDTO.ProductId,
                Name = productDTO.Name,
                Description = productDTO.Description,
                Price = productDTO.Price,
                Quantity = productDTO.Quantity,
                Stock = productDTO.Stock
            };
        }
    }
}
