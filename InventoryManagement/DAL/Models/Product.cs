using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.DAL.Models
{
    public class Product
    {
        [Key]
        public  int ProductId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public int Stock { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
