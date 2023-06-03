using InventoryManagement.BLL.DTOs;

namespace InventoryManagement.BLL.Service
{
    public interface IAuthService
    {
        string LoginUser(LoginDTO login);
        void RegisterUser(RegistrationDTO register);
    }
}
