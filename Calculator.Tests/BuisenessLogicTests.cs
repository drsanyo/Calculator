using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;
using System;

namespace Calculator.Tests
{
    [TestClass]
    public class BuisenessLogicTests
    {
        [TestMethod]
        public void PerformCalculationsTests_Add()
        {
            // arrange
            double first = 1;
            double second = 1;
            double result;
            double expectedResult = 2;
            string operatorAdd = "+";

            // act
            result = MainClass.PerformCalculations(first, second, operatorAdd);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PerformCalculationsTests_Subtract()
        {
            // arrange
            double first = 1;
            double second = 1;
            double result;
            double expectedResult = 0;
            string operatorAdd = "-";

            // act
            result = MainClass.PerformCalculations(first, second, operatorAdd);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PerformCalculationsTests_Multi()
        {
            // arrange
            double first = 1;
            double second = 1;
            double result;
            double expectedResult = 1;
            string operatorAdd = "*";

            // act
            result = MainClass.PerformCalculations(first, second, operatorAdd);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PerformCalculationsTests_Multi0()
        {
            // arrange
            double first = 1;
            double second = 0;
            double result;
            double expectedResult = 0;
            string operatorAdd = "*";

            // act
            result = MainClass.PerformCalculations(first, second, operatorAdd);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void PerformCalculationsTests_Divide()
        {
            // arrange
            double first = 1;
            double second = 1;
            double result;
            double expectedResult = 1;
            string operatorAdd = "/";

            // act
            result = MainClass.PerformCalculations(first, second, operatorAdd);

            // assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void PerformCalculationsTests_Divide0()
        {
            // arrange
            double first = 1;
            double second = 0;
            
            string operatorAdd = "/";

            // act
            MainClass.PerformCalculations(first, second, operatorAdd);

            // assert
            // Expecting Exception
        }
    }
}
