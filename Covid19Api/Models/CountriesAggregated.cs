using System;

namespace CsvParser.Models
{
    public class CountriesAggregated
    {
         public DateTime Date { get; set; }
         public string Country { get; set; }
         public int Confirmed { get; set; }
         public int Recovered { get; set; }
         public int Deaths { get; set; }
    }
}