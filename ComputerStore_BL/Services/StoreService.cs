using ComputerStore_DL.Interfaces;

namespace ComputerStore_BL.Services
{
    internal class ILibraryService : IStoreRepository
    {
        private readonly ILibraryService _storeService;

        public ILibraryService(ILibraryService libraryService)
        {
            _storeService = libraryService;
        }

        public string GetLibraryName()
        {
            throw new NotImplementedException();
        }

        public string GetStoreName()
        {
            return ((IStoreRepository)_storeService).GetStoreName();
        }
    }
}