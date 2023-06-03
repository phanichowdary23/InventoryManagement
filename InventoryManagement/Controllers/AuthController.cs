using InventoryManagement.BLL.DTOs;
using InventoryManagement.BLL.Service;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
        [ApiController]
        [Route("api/customers")]
        public class AuthController : ControllerBase
        {
            private readonly IAuthService authservice;
            public AuthController(IAuthService _authservice)
            {
                this.authservice = _authservice;
            }
            [HttpPost("register")]
            public IActionResult RegisterUser(RegistrationDTO register)
            {
                try
                {
                    authservice.RegisterUser(register);
                    return Ok("Successfully Registered");
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
            [HttpPost("login")]
            public IActionResult Login(LoginDTO login)
            {
                try
                {
                    var token = authservice.LoginUser(login);
                    return Ok(new { Token = token });
                }
                catch (Exception e)
                {
                    return BadRequest(e.Message);
                }
            }
        }
    }