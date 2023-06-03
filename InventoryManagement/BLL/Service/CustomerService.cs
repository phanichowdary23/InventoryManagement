using InventoryManagement.BLL.DTOs;
using InventoryManagement.DAL.Models;
using InventoryManagement.DAL.Repository;

namespace InventoryManagement.BLL.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepo _customerRepository;

        public CustomerService(ICustomerRepo customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public IEnumerable<CustomerDTO> GetAllCustomers()
        {
            var customers = _customerRepository.GetAllCustomers();
            return customers.Select(c => (CustomerDTO)c).ToList();
        }

        public CustomerDTO GetCustomerById(int customerId)
        {
            var customer = _customerRepository.GetCustomerById(customerId);
            return (CustomerDTO)customer;
        }

        public void AddCustomer(CustomerDTO customerDTO)
        {
            var customer = (Customer)customerDTO;
            _customerRepository.AddCustomer(customer);
        }

        public void UpdateCustomer(CustomerDTO customerDTO)
        {
            var customer = (Customer)customerDTO;
            _customerRepository.UpdateCustomer(customer);
        }

        public void DeleteCustomer(int customerId)
        {
            var customer = _customerRepository.GetCustomerById(customerId);
            if (customer != null)
            {
                _customerRepository.DeleteCustomer(customer);
            }
        }
    }
}
