using System;
using CsvHelper.Configuration.Attributes;

namespace CsvParser.Models
{
    public class TimeSeries19Covid
    {
        [Index(0)] public DateTime Date { get; set; }
        [Index(1)] public string Region { get; set; }
        [Index(2)] public string? State { get; set; }
        [Index(3)] public float Lat { get; set; }
        [Index(4)] public float Long { get; set; }
        [Index(5)] public int? Confirmed { get; set; }
        [Index(6)] public int? Recovered { get; set; }
        [Index(7)] public int? Deaths { get; set; }
    }
}