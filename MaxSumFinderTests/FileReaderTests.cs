using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaxSumFinder.Tests
{
    [TestClass()]
    public class FileReaderTests
    {
        [TestMethod()]
        public void ReadFileTest()
        {
            string path = "test.txt";

            var reader = new FileReader();

            reader.ReadFile(path);

            var text = reader.TextObject;
            
            Assert.IsNotNull(text);
        }

    }
}