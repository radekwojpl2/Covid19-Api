using System;

namespace CsvParser.Models
{
    public class TimeSeries19Covid
    {
        public DateTime Date { get; set; }
        public string Region { get; set; }
        public string? State { get; set; }
        public float Lat { get; set; }
        public float Long { get; set; }
        public int? Confirmed { get; set; }
        public int? Recovered { get; set; }
        public int? Deaths { get; set; }
    }
}