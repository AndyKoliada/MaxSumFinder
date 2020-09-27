using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace MaxSumFinder.Tests
{
    [TestClass()]
    public class FileProcessorTests
    {
        [TestMethod()]
        public void ProcessFileTest()
        {
            //ARRANGE
            var text = new List<string>() { "1,34,54,443,54,45",
                                            "5,6,4,5,6,6",
                                            "7.0,999999.0",
                                            "f,dd",
                                            "djf",
                                            "0,0,3" };

            int expectedMaxLine = 3;



            var processor = new FileProcessor();
            //ACT
            
            processor.ProcessFile(text);

            


            //ASSERT
            Assert.IsTrue(expectedMaxLine == processor.MaxSumLine);
        }
    }
}