using InventoryManagement.DAL.Models;

namespace InventoryManagement.DAL.Repository
{
    public interface IAdminRepo
    {
        Admin GetAdminById(int adminId);
        void AddAdmin(Admin admin);
        void UpdateAdmin(Admin admin);
        void DeleteAdmin(Admin admin);
        IEnumerable<Admin> GetAllAdmins();
    }
}
