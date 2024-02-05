using ComputerStore_Models.Models;
using ComputerStore_DL.Interfaces;
using ComputerStore_DL.MemoryDB;

namespace ComputerStore_DL.Repositories
{
    public class ComputerRepository : ComputerRepository
    {
        public void Add(Computer computer
            )
        {
            InMemoryDB.ComputerData.Add(computer);
        }

        public void Delete(int id)
        {
            var computer= GetById(id);
            if (computer  != null)
            {
                InMemoryDB.ComputerData.Remove(computer);
            }

        }

        public List<Computer> GetAll()
        {
            return InMemoryDB.ComputerData;
        }

        public Computer? GetById(int id)
        {
            return InMemoryDB.ComputerData.FirstOrDefault(a => a.Id == id);
        }

        public Computer? GetComputerById(int id)
        {
            throw new NotImplementedException();
        }


        public Computer? GetAllComputersByCustomerId(int customerId)
        {
            return InMemoryDB.ComputerData.Where(b => b.CustomerId == customerId).ToList();
        }

        List<Computer> ComputerRepository.GetAllCarsByBuyerId(int customerId)
        {
            throw new NotImplementedException();
        }
    }
}
