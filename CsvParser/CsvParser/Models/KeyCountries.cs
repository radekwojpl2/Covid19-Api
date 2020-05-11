using System;
using CsvHelper.Configuration.Attributes;

namespace CsvParser.Models
{
    public class KeyCountries
    {
        [Index(0)] public DateTime DateTime { get; set; }
        [Index(1)] public int China { get; set; }
        [Index(2)] public int US { get; set; }
        [Index(3)] public int UK { get; set; }
        [Index(4)] public int Italy { get; set; }
        [Index(5)] public int France { get; set; }
        [Index(6)] public int Germany { get; set; }
        [Index(7)] public int Spain { get; set; }
        [Index(8)] public int Iran { get; set; }
    }
}