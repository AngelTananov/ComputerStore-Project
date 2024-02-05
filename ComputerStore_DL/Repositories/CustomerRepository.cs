using ComputerStore_DL.Interfaces;
using ComputerStore_DL.MemoryDB;
using ComputerStore_Models.Models;

namespace ComputerStore_DL.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        public void Add(Customer customer)
        {
            InMemoryDB.CustomerData.Add(customer);
        }

        public void Delete(int id)
        {
            var customer = GetById(id);
            if (customer != null)
            {
                InMemoryDB.CustomerData.Remove(customer);
            }
            
        }

        public List<Customer> GetAll()
        {
            return InMemoryDB.CustomerData;
        }

        public Customer? GetById(int id)
        {
            return InMemoryDB.CustomerData.FirstOrDefault(a => a.Id == id);
        }
    }
}
