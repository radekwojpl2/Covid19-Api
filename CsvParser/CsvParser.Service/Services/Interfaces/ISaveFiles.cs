namespace CsvParser.Services
{
    public interface ISaveFiles
    {
        public bool SaveCountriesAggregatedFile();
        public bool SaveUsConfirmedFile();
        public bool SaveUsDeathsFile();
        public bool SaveWorldWideAggregatedFile();
        public bool SaveKeyCountriesPivotedFile();
        public bool SaveTimeSeries19CovidCombinedFile();
        public bool SaveReferencesFile();
    }
}