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

        public string Username { get; set; }

        public string Password { get; set; }

        public static implicit operator CustomerDTO(Customer customer)
        {
            if (customer == null) return null;
            return new CustomerDTO
            {
                Id = customer.Id,
                Name = customer.Name,
                Email = customer.Email,
                Address = customer.Address,
                PhoneNumber = customer.PhoneNumber,
                Username = customer.Username,
                Password = customer.Password
            };
        }

        public static explicit operator Customer(CustomerDTO customerDTO)
        {
            if (customerDTO == null) return null;
            return new Customer
            {
                Id = customerDTO.Id,
                Name = customerDTO.Name,
                Email = customerDTO.Email,
                Address = customerDTO.Address,
                PhoneNumber = customerDTO.PhoneNumber,
                Username = customerDTO.Username,
                Password = customerDTO.Password
            };
        }
    }
}
