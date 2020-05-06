using System.Collections.Generic;
using System.Threading.Tasks;
using Covid19Api.Repositories.Interfaces;
using Covid19Api.Services.Interfaces;

namespace Covid19Api.Services
{
    public class CsvService : ICsvService
    {
        private readonly ICsvRepository _csvRepository;

        public CsvService(ICsvRepository csvRepository)
        {
            _csvRepository = csvRepository;
        }

        Task<IEnumerable<string>> ICsvService.GetAllFileNames()
        {
            throw new System.NotImplementedException();
        }
    }
}