using NUnit.Framework;

namespace CsvParser.Tests.Integration
{
    [TestFixture]
    public class ProgramTests
    {
        [Test]
        public void Test()
        {
            var cos = Program.Main(new []{"/home/radek/Desktop/Covid19-Api/Covid19-Api/dataset/data", "/home/radek/Desktop/Covid19-Api/Covid19-Api/JsonData"});
            
           
           
            Assert.AreEqual(cos, 1);
        }
        
    }
}