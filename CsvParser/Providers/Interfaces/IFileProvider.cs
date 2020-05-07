namespace CsvParser.Providers.Interfaces
{
    public interface IFileProvider
    {
        public string ParseCountriesAggregatedFile();
        public string ParseUsConfirmedFile();
        public string ParseUsDeathsFile();
        public string ParseWorldWideAggregatedFile();
        public string ParseUKeyCountriesPivotedFile();
        public string ParseTimeSeries19CovidCombinedFile();
        public string ParseReferencesFile();

    }
}