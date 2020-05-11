using System.IO;
using CsvHelper;

namespace CsvParser.Providers.Interfaces
{
    public interface IStreamProvider
    {
        StreamReader StreamReader(string path);

        CsvReader CsvReader(StreamReader reader);
    }
}