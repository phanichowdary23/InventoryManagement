using InventoryManagement.DAL.Models;
using System.Security.Principal;

namespace InventoryManagement.BLL.DTOs
{
    public class AdminDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public static explicit operator AdminDTO(Admin admin)
        {
            if (admin == null) return null;
            return new AdminDTO
            {
                Id = admin.Id,
                Username = admin.Username,
                Password = admin.Password,
                FullName = admin.FullName,
                Email = admin.Email
            };
        }

        public static explicit operator Admin(AdminDTO adminDTO)
        {
            if (adminDTO == null) return null;
            return new Admin
            {
                Id = adminDTO.Id,
                Username = adminDTO.Username,
                Password = adminDTO.Password,
                FullName = adminDTO.FullName,
                Email = adminDTO.Email
            };
        }
    }
}