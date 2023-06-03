using InventoryManagement.DAL.Models;

namespace InventoryManagement.BLL.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

        public static explicit operator CustomerDTO(Customer customer)
        {
            return new CustomerDTO
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Address = customer.Address,
                PhoneNumber = customer.PhoneNumber
            };
        }

        public static explicit operator Customer(CustomerDTO customerDTO)
        {
            return new Customer
            {
                Id = customerDTO.Id,
                Name = customerDTO.Name,
                Email = customerDTO.Email,
                Address = customerDTO.Address,
                PhoneNumber = customerDTO.PhoneNumber
            };
        }
    }
}
