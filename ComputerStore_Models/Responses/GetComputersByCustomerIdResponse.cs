using ComputerStore_Models.Models;

namespace ComputerStore_Models.Responses
{
    public class GetComputersByCustomerResponse
    {
        public Customer Customer { get; set; }

        public List<Computer> Computer { get; set; }
    }
}