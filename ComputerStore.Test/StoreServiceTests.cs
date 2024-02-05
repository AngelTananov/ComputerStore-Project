using ComputerStore_BL.Services;
using ComputerStore_DL.Interfaces;
using ComputerStore_Models.Models;
using Moq;

namespace ComputerStore.Test
{
    public class StoreServiceTests
    {
        public static List<Computer> ComputerData = new List<Computer>()
        {
            new Computer()
            {
                Id = 1,
                CPU = "Nvidia",
                Model ="RTX4060",
                Memory ="1TB",
                ReleaseDate = new DateTime(2018,02, 15),
               
            },
            new Computer()
            {
                 Id = 2,
                CPU = "Nvidia",
                Model ="RTX4080",
                Memory ="1TB",
                ReleaseDate = new DateTime(2020,04, 11),
            }
            new Computer()
            {
                 Id = 3,
                CPU = "Nvidia",
                Model ="RTX1060",
                Memory ="1TB",
                ReleaseDate = new DateTime(2014,02, 17),
            }
            new Computer()
            {
                 Id = 4,
                CPU = "Nvidia",
                Model ="RTX2060",
                Memory ="1TB",
                ReleaseDate = new DateTime(2017,11, 11),
            }
            new Computer()
            {
                 Id = 5,
                CPU = "Nvidia",
                Model ="RTX4080TI",
                Memory ="1TB",
                ReleaseDate = new DateTime(2022,02, 22),
            }
        };

        public static List<Customer> CustomerData =
            new List<Customer>()
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
                    Name = "Customer 2",
                    BirthDay = DateTime.Now
                },
                new Customer()
                {
                    Id = 3,
                    Name = "Customer 3",
                    BirthDay = DateTime.Now
                }
                 new Customer()
                {
                    Id = 4,
                    Name = "Customer 4",
                    BirthDay = DateTime.Now
                }
                  new Customer()
                {
                    Id = 5,
                    Name = "Customer 5",
                    BirthDay = DateTime.Now
                }
            };
        [Fact]
        public void GetAllBooksCount_OK()
        {
            //setup
            var input = 10;
            var customerId = 1;
            var expectedCount = 12;

            var mockedComputerRepository =
                new Mock<IComputerRepository>();
            var mockedCustomerRepository =
                new Mock<ICustomerRepository>();

            mockedComputerRepository.Setup(
                x =>
                    x.GetAllComputerByCustomer(customerId))
                .Returns(ComputerData.Where(b => b.CustomerId == customerId).ToList());

            //inject
            var computerService =
                new ComputerService(mockedComputerRepository.Object);
            var customerService =
                new CustomerService(mockedCustomerRepository.Object);
            var storeService =
                new StoreService(computerService, customerService);

            //act
            var result =
                storeService.GetAllBooksCount(input, customerId);

            //Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void GetAllBooksCount_WrongAuthorId()
        {
            //setup
            var input = 10;
            var customerId = 111;
            var expectedCount = 10;

            var mockedBookRepository =
                new Mock<IComputerRepository>();
            var mockedAuthorRepository =
                new Mock<ICustomerRepository>();

            mockedBookRepository.Setup(x => x.GetAllComputersByCustomerId(customerId))
                                .Returns(ComputerData.Where(b => b.CustomerId == customerId).ToList());

            //inject
            var computerService =
                new ComputerService(mockedBookRepository.Object);
            var customerService =
                new AuthorService(mockedAuthorRepository.Object);
            var libraryService =
                new StoreService(computerService, customerService);

            //act
            var result = storeService.GetAllComputersCount(input, customerId);

            //Assert
            Assert.Equal(expectedCount, result);
        }

        [Fact]
        public void GetAllBooksCount_NegativeInput()
        {
            //setup
            var input = -10;
            var authorId = 111;
            var expectedCount = 0;

              var mockedBookRepository =
                new Mock<IComputerRepository>();
            var mockedAuthorRepository =
                new Mock<ICustomerRepository>();

            mockedBookRepository.Setup(x => x.GetAllComputersByCustomerId(customerId))
                                .Returns(ComputerData.Where(b => b.CustomerId == customerId).ToList());

            //inject
            var computerService =
                new ComputerService(mockedBookRepository.Object);
            var customerService =
                new AuthorService(mockedAuthorRepository.Object);
            var libraryService =
                new StoreService(computerService, customerService);

            //act
            var result = storeService.GetAllComputersCount(input, customerId);

            //Assert
            Assert.Equal(expectedCount, result);
        }
    }
}