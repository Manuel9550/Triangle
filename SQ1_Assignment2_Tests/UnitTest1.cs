using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sq1_Assignment_2;
namespace SQ1_Assignment2_Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetSideTest()
        {
            Triangle test = new Triangle(5, 10);

            int result = test.GetSideA();

            Assert.AreEqual(result, 5);

        }
    }
}
