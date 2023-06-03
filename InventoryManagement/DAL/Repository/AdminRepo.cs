using InventoryManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace InventoryManagement.DAL.Repository
{
    public class AdminRepo : IAdminRepo
    {
        private readonly AppDbContext _dbContext;

        public AdminRepo(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Admin> GetAllAdmins()
        {
            return _dbContext.Admins.ToList();
        }

        public Admin GetAdminById(int adminId)
        {
            return _dbContext.Admins.Find(adminId);
        }

        public void AddAdmin(Admin admin)
        {
            _dbContext.Admins.Add(admin);
            _dbContext.SaveChanges();
        }

        public void UpdateAdmin(Admin admin)
        {
            _dbContext.Entry(admin).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void DeleteAdmin(Admin admin)
        {
            _dbContext.Admins.Remove(admin);
            _dbContext.SaveChanges();
        }
    }
}
