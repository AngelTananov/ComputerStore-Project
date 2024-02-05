using ComputerStore_Models.Models;

namespace ComputerStore_BL.Interfaces
{
    public interface IComputerService
    {
            List<Computer> GetAll();

            Computer? GetBooksById(int id);

            void Add(Computer computer);

            void Delete(int id);
    }
}
