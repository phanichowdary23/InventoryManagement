using InventoryManagement.BLL.DTOs;
using InventoryManagement.DAL.Models;
using InventoryManagement.DAL.Repository;

namespace InventoryManagement.BLL.Service
{
    public class AdminService
    {
        private readonly IAdminRepo _adminRepository;

        public AdminService(IAdminRepo adminRepository)
        {
            _adminRepository = adminRepository;
        }

        public IEnumerable<AdminDTO> GetAllAdmins()
        {
            var admins = _adminRepository.GetAllAdmins();
            return admins.Select(a => (AdminDTO)a).ToList();
        }

        public AdminDTO GetAdminById(int adminId)
        {
            var admin = _adminRepository.GetAdminById(adminId);
            return (AdminDTO)admin;
        }

        public void AddAdmin(AdminDTO adminDTO)
        {
            var admin = (Admin)adminDTO;
            _adminRepository.AddAdmin(admin);
        }

        public void UpdateAdmin(AdminDTO adminDTO)
        {
            var admin = (Admin)adminDTO;
            _adminRepository.UpdateAdmin(admin);
        }

        public void DeleteAdmin(int adminId)
        {
            var admin = _adminRepository.GetAdminById(adminId);
            if (admin != null)
            {
                _adminRepository.DeleteAdmin(admin);
            }
        }
    }
}
