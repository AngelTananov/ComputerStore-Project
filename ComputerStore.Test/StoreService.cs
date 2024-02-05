using ComputerStore_BL.Services;
namespace ComputerStore.Test
{
    internal class StoreService
    {
        private ComputerService computerService;
        private CustomerService customerService;

        public StoreService(ComputerService computerService, CustomerService customerService)
        {
            this.computerService = computerService;
            this.customerService = customerService;
        }

        internal IEnumerable<object> GetAllComputersCount(int input, int customerId)
        {
            throw new NotImplementedException();
        }
    }
}