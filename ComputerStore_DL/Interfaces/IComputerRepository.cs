using ComputerStore_Models.Models;

namespace ComputerStore_DL.Interfaces
{
    public interface ICustomerRepository
    {
        List<Computer> GetAll();

        List<Computer> GetAllComputerByCustomer(int computerId);

        Computer? GetById(int id);

        void Add(Computer customer);

        void Delete(int id);
        Computer? GetById(int id);
    }
}
