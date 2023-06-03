using InventoryManagement.BLL.DTOs;
using InventoryManagement.BLL.Service;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    [Route("api/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            var products = _productService.GetAllProducts();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _productService.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpPost]
        public IActionResult AddProduct(ProductDTO productDTO)
        {
            _productService.AddProduct(productDTO);
            return CreatedAtAction(nameof(GetProductById), new { id = productDTO.ProductId }, productDTO);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, ProductDTO productDTO)
        {
            if (id != productDTO.ProductId)
            {
                return BadRequest();
            }

            _productService.UpdateProduct(productDTO);
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            _productService.DeleteProduct(id);
            return NoContent();
        }
    }
}
