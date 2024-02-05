using ComputerStore_Models.Responses;
using ComputerStore_Models.Requests;
using ComputerStore_BL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ComputerstoreApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StoreController : ControllerBase
    {
        private readonly IStoreService _storeService;
        public StoreController(IStoreService storeService)
        {
            _storeService = storeService;
        }

        
        [HttpPost("GetAllComputersByCustomerId")]
        public GetComputersByCustomerResponse? GetAllComputersByCustomerId(GetComputersByCustomerRequest request)
        {
            return _storeService.GetComputersByCustomerId(request);
        }
    }
}
