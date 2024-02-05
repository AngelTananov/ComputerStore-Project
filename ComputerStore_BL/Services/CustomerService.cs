using ComputerStore_Models.Models;
using ComputerStore_DL.Interfaces;
using ComputerStore_BL.Interfaces;


namespace ComputerStore_BL.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Add(Customer customer)
        {
            _customerRepository.Add(customer);
        }

        public void Delete(int id)
        {
            _customerRepository.Delete(id);
        }

        public List<Customer> GetAll()
        {
            return _customerRepository.GetAll();  
        }

        public Customer? GetById(int id)
        {
            return _customerRepository.GetById(id);
        }
    }
}
