using InventoryManagement.BLL.DTOs;

namespace InventoryManagement.BLL.Service
{
    public interface IProductService
    {
        public IEnumerable<ProductDTO> GetAllProducts();
        public ProductDTO GetProductById(int productId);
        void AddProduct(ProductDTO productDTO);
        void UpdateProduct(ProductDTO productDTO);
        void DeleteProduct(int productId);
    }
}
