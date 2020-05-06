using System.Collections.Generic;
using System.Threading.Tasks;

namespace Covid19Api.Services.Interfaces
{
    public interface ICsvService
    {
         public Task<IEnumerable<string>>  GetAllFileNames(); 
    }
}