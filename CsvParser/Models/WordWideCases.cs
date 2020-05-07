using System;
using CsvHelper.Configuration.Attributes;

namespace CsvParser.Models
{
    public class WordWideCases
    {
        [Index(0)]
        public string Date { get; set; }
        [Index(1)]
        public int Confirmed { get; set; }
        [Index(2)]
        public int Recovered { get; set; }
        [Index(3)]
        public int Deaths { get; set; }
        [Index(4)]
        public float? IncreaseRate { get; set; }
    }
}