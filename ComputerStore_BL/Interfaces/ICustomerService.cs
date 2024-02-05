using ComputerStore_Models.Models;

namespace ComputerStore_BL.Interfaces
{
    public interface ICustomerService
    {
        List<Customer> GetAll();

        Customer? GetById(int id);

        void Add(Customer author);

        void Delete(int id);
    }
}
