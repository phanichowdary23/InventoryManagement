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
            return (IEnumerable<CustomerDTO>)_customerRepository.GetAllCustomers();
       
        }

        public CustomerDTO GetCustomerById(int customerId)
        {
            return (CustomerDTO)_customerRepository.GetCustomerById(customerId);
        }

        public void AddCustomer(CustomerDTO customer)
        {
            
            _customerRepository.AddCustomer((Customer)customer);
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
                _customerRepository.DeleteCustomer(customerId);
            }
        }
    }
}
