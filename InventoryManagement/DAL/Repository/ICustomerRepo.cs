using InventoryManagement.DAL.Models;
using System.Collections.Generic;

namespace InventoryManagement.DAL.Repository
{
    public interface ICustomerRepo
    {
        void AddCustomer(Customer customer);
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(int customerId);
        Customer GetCustomerById(int customerId);
        List<Customer> GetAllCustomers();
        void DeleteCustomer(Customer customer);
    }
}
