using InventoryManagement.BLL.DTOs;
using InventoryManagement.BLL.Service;
using Microsoft.AspNetCore.Mvc;

namespace InventoryManagement.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        public IActionResult GetAllCustomers()
        {
            var customers = _customerService.GetAllCustomers();
            return Ok(customers);
        }

        [HttpGet("{id}")]
        public IActionResult GetCustomerById(int id)
        {
            var customer = _customerService.GetCustomerById(id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        [HttpPost]
        public IActionResult AddCustomer(CustomerDTO customerDTO)
        {
            _customerService.AddCustomer(customerDTO);
            return CreatedAtAction(nameof(GetCustomerById), new { id = customerDTO.Id }, customerDTO);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCustomer(int id, CustomerDTO customerDTO)
        {
            if (id != customerDTO.Id)
            {
                return BadRequest();
            }

            _customerService.UpdateCustomer(customerDTO);
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteCustomer(int id)
        {
            _customerService.DeleteCustomer(id);
            return NoContent();
        }
    }
}
