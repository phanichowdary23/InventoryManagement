using InventoryManagement.BLL.DTOs;

namespace InventoryManagement.BLL.Service
{
    public interface IAdminService
    {
        IEnumerable<AdminDTO> GetAllAdmins();
        AdminDTO GetAdminById(int adminId);
        void AddAdmin(AdminDTO adminDTO);
        void UpdateAdmin(AdminDTO adminDTO);
        void DeleteAdmin(int adminId);
    }
}
