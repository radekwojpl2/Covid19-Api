using System.Collections.Generic;
using System.Threading.Tasks;
using Covid19Api.Repositories.Interfaces;

namespace Covid19Api.Repositories
{
    public class CsvRepository : ICsvRepository
    {
        public Task<IEnumerable<string>> GetAllFileNames()
        {
            throw new System.NotImplementedException();
        }
    }
}