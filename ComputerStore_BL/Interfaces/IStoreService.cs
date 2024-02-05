using ComputerStore_Models.Responses;
using ComputerStore_Models.Requests;

namespace ComputerStore_BL.Interfaces
{
    public interface IStoreService
    {
        GetComputersByCustomerResponse?
            GetBooksByAuthor(GetComputersByCustomerRequest request);
    }
}
