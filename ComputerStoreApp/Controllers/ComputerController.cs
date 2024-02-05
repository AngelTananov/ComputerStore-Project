using ComputerStore_Models.Models;
using ComputerStore_BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ComputerstoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputerController : ControllerBase
    {
        private readonly IComputerService _computerService;

        public ComputerController(IComputerService computerService)
        {
            _computerService = computerService;
        }

        [HttpGet(template: "GetComputerById")]
        public Computer GetComputerById(int id)
        {
            return _computerService.GetComputersById(id);
        }

        [HttpGet(template: "GetAllComputers")]
        public List<Computer> GetAllComputers()
        {
            return _computerService.GetAll();
        }

        [HttpPost]
        public void Add(Computer computer)
        {
            _computerService.Add(computer);
        }

        [HttpDelete]
        public void Delete(int id)
        {
            _computerService.Delete(id);
        }
    }
}
