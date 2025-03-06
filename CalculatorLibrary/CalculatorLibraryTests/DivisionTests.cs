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
    public class DivisionTests
    {
        [TestMethod()]
        [DataRow(10, 5, 2)]
        [DataRow(1, 1, 1)]
        [DataRow(100, 2, 50)]
        [DataRow(3, 3, 1)]
        [DataRow(40, 4, 10)]
        public void DivideTest(int number1, int number2, int expectedResult)
        {
            //Arrange
            int actualResult;
            Division division = new Division();
            //Act
            actualResult = division.Divide(number1, number2);
            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }

    }
}