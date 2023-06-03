using InventoryManagement.BLL.DTOs;
using InventoryManagement.DAL.Models;
using InventoryManagement.DAL.Repository;

namespace InventoryManagement.BLL.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepo _productRepo;

        public ProductService(IProductRepo productRepo)
        {
            _productRepo = productRepo;
        }

        public IEnumerable<ProductDTO> GetAllProducts()
        {
            var products = _productRepo.GetAllProducts();
            return products.Select(p => (ProductDTO)p).ToList();
        }

        public ProductDTO GetProductById(int productId)
        {
            var product = _productRepo.GetProductById(productId);
            return (ProductDTO)product;
        }

        public void AddProduct(ProductDTO productDTO)
        {
            var product = (Product)productDTO;
            _productRepo.AddProduct(product);
        }

        public void UpdateProduct(ProductDTO productDTO)
        {
            var product = (Product)productDTO;
            _productRepo.UpdateProduct(product);
        }

        public void DeleteProduct(int productId)
        {
            var product = _productRepo.GetProductById(productId);
            if (product != null)
            {
                _productRepo.DeleteProduct(product);
            }
        }
    }
}
