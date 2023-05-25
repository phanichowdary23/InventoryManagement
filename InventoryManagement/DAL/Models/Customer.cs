using System.ComponentModel.DataAnnotations;

namespace InventoryManagement.DAL.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
