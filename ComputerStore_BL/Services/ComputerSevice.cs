using ComputerStore_Models.Models;
using ComputerStore_BL.Interfaces;
using ComputerStore_DL.Interfaces;
using ComputerStore_DL.Repositories;

namespace ComputerStore_BL.Services
{
    public class BookService : IComputerService
    {
        private readonly ComputerRepository _bookRepository;

        public BookService(ComputerRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Add(Computer book)
        {
            _bookRepository.Add(book);
        }

        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }

        public List<Computer> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public Computer? GetBooksById(int id)
        {
            throw new NotImplementedException();
        }

        public Computer? GetById(int id)
        {
            return _computerRepository.GetById(id);
        }

       
    }
}
