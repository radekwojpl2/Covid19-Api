using System.Globalization;
using System.IO;
using CsvHelper;
using CsvParser.Providers.Interfaces;

namespace CsvParser.Providers
{
    public class StreamProvider : IStreamProvider
    {
        public StreamReader StreamReader(string path)
        {
            return new StreamReader(path);
        }

        public CsvReader CsvReader(StreamReader reader)
        {
            return  new CsvReader(reader, CultureInfo.CurrentCulture);
        }
    }
}