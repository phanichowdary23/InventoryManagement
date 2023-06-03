using InventoryManagement.BLL.DTOs;
using InventoryManagement.BLL.Service;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    [Route("api/admins")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private readonly IAdminService _adminService;

        public AdminController(IAdminService adminService)
        {
            _adminService = adminService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<AdminDTO>> GetAllAdmins()
        {
            var admins = _adminService.GetAllAdmins();
            return Ok(admins);
        }

        [HttpGet("{id}")]
        public ActionResult<AdminDTO> GetAdminById(int id)
        {
            var admin = _adminService.GetAdminById(id);
            if (admin == null)
            {
                return NotFound();
            }
            return Ok(admin);
        }

        [HttpPost]
        public IActionResult AddAdmin(AdminDTO adminDTO)
        {
            _adminService.AddAdmin(adminDTO);
            return CreatedAtAction(nameof(GetAdminById), new { id = adminDTO.Id }, adminDTO);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAdmin(int id, AdminDTO adminDTO)
        {
            if (id != adminDTO.Id)
            {
                return BadRequest();
            }

            _adminService.UpdateAdmin(adminDTO);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAdmin(int id)
        {
            _adminService.DeleteAdmin(id);
            return NoContent();
        }
    }
}
