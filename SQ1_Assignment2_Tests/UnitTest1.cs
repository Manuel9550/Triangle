using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sq1_Assignment_2;
using System;


namespace SQ1_Assignment2_Tests 
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetSideTest()
        {
            Triangle test = new Triangle(10, 5);

            int result = test.GetSideA();

            Assert.AreEqual(result, 10);

        }

        [TestMethod]
        public void TestHypotenuse()
        {
            Triangle test = new Triangle(10, 5);

            double result = test.GetHypotenuse();
            double expected = 11.18;

            // get the acceptble difference value
            double AcceptableRange = 0.01;

            bool resultBool = Math.Abs(result - expected) <= AcceptableRange;

            Assert.AreEqual(resultBool, true);

        }

        [TestMethod]
        public void TestHypotenuseException()
        {
            Triangle test = new Triangle(0, 0);

            double result = test.GetHypotenuse();
            double expected = 0.0;

            // get the acceptble difference value
            double AcceptableRange = 0.01;

            bool resultBool = Math.Abs(result - expected) <= AcceptableRange;

            Assert.AreEqual(resultBool, true);

        }

        [TestMethod]
        public void TestAreaNormal()
        {
            Triangle test = new Triangle(2, 5);

            double result = test.GetArea();

            Assert.AreEqual(result, 5.0);

        }
    }


}
