using InventoryManagement.BLL.DTOs;
using InventoryManagement.DAL.Repository;

namespace InventoryManagement.BLL.Service
{
    public class AuthService
    {
        public readonly ICustomerRepo customerrepo;
        public readonly IConfiguration configuration;
        public AuthService(ICustomerRepo _customerrrepo, IConfiguration _configuration)
        {
            customerrepo = _customerrrepo;
            configuration = _configuration;
        }

        public string LoginUser(LoginDTO login)
        {
            throw new NotImplementedException();
        }

        public void RegisterUser(RegistrationDTO register)
        {
            throw new NotImplementedException();
        }
    }
}