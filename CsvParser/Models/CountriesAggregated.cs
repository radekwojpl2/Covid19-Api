using System;
using CsvHelper.Configuration.Attributes;

namespace CsvParser.Models
{
    public class CountriesAggregated
    {
        [Index(0)]
        public DateTime Date { get; set; }
        [Index(1)]
        public string Country { get; set; }
        [Index(2)]
        public int Confirmed { get; set; }
        [Index(3)]
        public int Recovered { get; set; }
        [Index(4)]
        public int Deaths { get; set; }
    }
}