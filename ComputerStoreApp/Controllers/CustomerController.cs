using ComputerStore_BL.Interfaces;
using ComputerStore_Models.Models;
using Microsoft.AspNetCore.Mvc;

namespace ComputerStoreApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;
    

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet( "GetAll")]
        public IEnumerable<Customer> GetAll()
        {
            return _customerService.GetAll();
        }
        [HttpGet("GetById")]
        public Customer? GetById(int id) 
        { 
            return _customerService.GetById(id);
        }

        [HttpGet("Add")]
        public void Add([FromBody] Customer customer)
        { 
            _customerService.Add(customer);
        }

        [HttpGet("Delete")]
        public void Delete(int id)
        {
            _customerService.Delete(id);
        }
    }
}
