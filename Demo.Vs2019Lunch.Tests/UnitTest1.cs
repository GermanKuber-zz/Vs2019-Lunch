using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Demo.Vs2019Lunch.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Success_test()
        {
            var dataGenerator = new DataGenerator();
            var list = dataGenerator.Generate(9);
            Assert.AreEqual(list.Count, 9);
        }
        [TestMethod]
        public void Fail_test()
        {
            var dataGenerator = new DataGenerator();

            var list = dataGenerator.Generate(9);
            list.First().Value = "Test Change";
            Assert.AreEqual(list.Count, 15);
        }
    }
}
