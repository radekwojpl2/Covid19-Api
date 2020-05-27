using CsvParser.Providers;
using NUnit.Framework;

namespace CsvParser.Tests.Unit
{
    [TestFixture]
    public class GitFileProviderTests
    {
        [Test]
        public void TestMethod()
        {
            var test = new GitFileProvider();

           var test2 = test.ReadCountriesAggregatedFile("elo");
        }
    }
}