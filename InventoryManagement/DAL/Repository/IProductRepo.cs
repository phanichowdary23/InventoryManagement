using InventoryManagement.DAL.Models;
using System.Collections.Generic;

namespace InventoryManagement.DAL.Repository
{
    public interface IProductRepo
    {
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int productId);
        Product GetProductById(int productId);
        List<Product> GetAllProducts();
        void DeleteProduct(Product product);
    }
}
