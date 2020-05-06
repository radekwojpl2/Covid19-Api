using System.Collections.Generic;
using System.Threading.Tasks;

namespace Covid19Api.Repositories.Interfaces
{
    public interface ICsvRepository
    {
         public Task<IEnumerable<string>> GetAllFileNames();
    }
}