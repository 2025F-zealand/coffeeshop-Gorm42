using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLibrary.Tests
{
    [TestClass()]
    public class SubtractionTests
    {
        [TestMethod()]
        [DataRow(2, 2, 0)]
        [DataRow(15, 5, 10)]
        [DataRow(456, 123, 333)]
        public void MinusTest(int number1, int number2, int expectedResult)
        {
            //Arrange
            int actualResult;
            Subtraction subtraction = new Subtraction();
            //Act
            actualResult = subtraction.Minus(number1, number2);
            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

    }
}