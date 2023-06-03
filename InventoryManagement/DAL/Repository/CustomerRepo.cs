using System.Collections.Generic;
using System.Linq;
using InventoryManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.DAL.Repository
{
    public class CustomerRepo : ICustomerRepo
    {
        private readonly AppDbContext _context;

        public CustomerRepo(AppDbContext context)
        {
            _context = context;
        }
        public void AddCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            _context.Customers.Update(customer);
            _context.SaveChanges();
        }

        public void DeleteCustomer(int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            _context.Customers.Remove(customer);
            _context.SaveChanges();
        }

        public Customer GetCustomerById(int customerId)
        {
            return _context.Customers.Find(customerId);
        }

        public List<Customer> GetAllCustomers()
        {
            return _context.Customers.ToList();
        }

        public Customer GetByUsername(string username)
        {
            return _context.Customers.Find(username);
        }
        public void Register(string username, string password, string email, string fullname)
        {
            Customer user = new Customer();
            user.Username = username;
            user.Password = password;
            user.Email = email;
            user.Name = fullname;
            _context.Customers.Add(user);
            _context.SaveChanges();
        }
        public Customer Login(string username, string password)
        {
            return _context.Customers.FirstOrDefault(x => x.Username == username && x.Password == password);
        }
        public void SaveChanges()
        {
            _context.SaveChanges();
        }

    }
}
