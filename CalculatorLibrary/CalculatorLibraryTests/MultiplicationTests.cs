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
    public class MultiplicationTests
    {
        [TestMethod()]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 9)]
        [DataRow(4, 4, 16)]
        [DataRow (5, 5, 25)]
        [DataRow(25000, 340, 8500000)]

        public void MultipleTest(int number1, int number2, int expectedResult)
        {
            //Arrange
            int actualResult;
            Multiplication multiplication = new Multiplication();
            //Act
            actualResult = multiplication.Multiple(number1, number2);

            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}