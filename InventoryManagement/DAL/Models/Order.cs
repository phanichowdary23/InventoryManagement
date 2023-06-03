using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.DAL.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime OrderDate { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public decimal TotalPrice { get; set; }

        public virtual Product Product { get; set; }
        public Customer Customer { get; set; }

        public ICollection<Product> Products { get; set; }

        public int CustomerId { get; set; }
        public object Orders { get; internal set; }
    }
}
