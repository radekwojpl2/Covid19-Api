namespace CsvParser.Providers.Interfaces
{
    public interface IFileProvider
    {
        public string ParseCountriesAggregatedFile(string pathToFolder);
        public string ParseUsConfirmedFile(string pathToFolder);
        public string ParseUsDeathsFile(string pathToFolder);
        public string ParseWorldWideAggregatedFile(string pathToFolder);
        public string ParseKeyCountriesPivotedFile(string pathToFolder);
        public string ParseTimeSeries19CovidCombinedFile(string pathToFolder);
        public string ParseReferencesFile(string pathToFolder);

    }
}