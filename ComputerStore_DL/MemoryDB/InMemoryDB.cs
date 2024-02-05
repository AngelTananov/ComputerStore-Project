
using ComputerStore_Models.Models;

namespace ComputerStore_DL.MemoryDB
{
    public static class InMemoryDB
    {
        public static List<Customer> CustomerData = new List<Customer>()
        {
            new Customer()
            {
                Id = 1,
                Name = "Customer 1",
                BirthDay = DateTime.Now
            },
              new Customer()
            {
                Id = 2,
                Name = "Customer  2",
                BirthDay = DateTime.Now
            },
                new Customer()
            {
                Id = 3,
                Name = "Customer  3",
                BirthDay = DateTime.Now
            }
        };

        public static List<Computer> ComputerData = new List<Computer>()
        {
            new Computer()
            {
                Id = 1,
                CPU ="Nvidia",
            
                Memory ="1TB",
                ReleaseDate = new DateTime(2005,02, 12),
                CustomerId = 1,
            },
            new Computer()
            
               {
                Id = 2,
                CPU ="Nvidia",

                Memory ="2TB",
                ReleaseDate = new DateTime(2015,12, 02),
                CustomerId = 2,
            },
            new Computer()
            {
                Id = 3,
                CPU ="Nvidia 4080RTX",

                Memory ="500GB",
                ReleaseDate = new DateTime(2021,01, 01),
                CustomerId = 3,
            }
        };

        }
}
