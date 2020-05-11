using System;

namespace CsvParser.Models
{
    public class WordWideCases
    {
        public string Date { get; set; }
        public int Confirmed { get; set; }
        public int Recovered { get; set; }
        public int Deaths { get; set; }
        public float? IncreaseRate { get; set; }
    }
}