using InventoryManagement.BLL.DTOs;

namespace InventoryManagement.BLL.Service
{
    public interface ICustomerService
    {
        public IEnumerable<CustomerDTO> GetAllCustomers();
        public CustomerDTO GetCustomerById(int customerId);
        void AddCustomer(CustomerDTO customerDTO);
        void UpdateCustomer(CustomerDTO customerDTO);
        void DeleteCustomer(int customerId);
    }
}
