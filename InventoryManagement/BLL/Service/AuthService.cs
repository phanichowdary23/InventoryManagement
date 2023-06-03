using InventoryManagement.BLL.DTOs;
using InventoryManagement.DAL.Models;
using InventoryManagement.DAL.Repository;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

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

        public string Logincustomer(LoginDTO login)
        {
            var customer = customerrepo.Login(login.Username, login.Password);
            if (customer == null)
            {
                throw new ApplicationException("Invalid Username or Password");
            }
            var jwtToken = GenerateJwtToken(customer);
            return jwtToken;
        }

        public void Registercustomer(RegistrationDTO register)
        {
            if (customerrepo.GetByUsername(register.Username) != null)
            {
                throw new ApplicationException("customername already in use!");
            }
            
            customerrepo.Register(register.Username, register.Password, register.Email, register.FullName);
            customerrepo.SaveChanges();
        }
        private string GenerateJwtToken(Customer customer)
        {
            var key = Encoding.ASCII.GetBytes(configuration["Jwt:key"]);
            var claim = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, customer.Id.ToString()),
                new Claim(ClaimTypes.Name, customer.Username)
            };
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claim),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}