using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComputerStore_Models.Models;

namespace ComputerStore_DL.Interfaces
{
    public interface ICustomerRepository
    {
        List<Customer> GetAll();

        Customer? GetById(int id);

        void Add(Customer customer);

        void Delete(int id);
    }
}
