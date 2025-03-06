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
    public class AdditionTests
    {
        [TestMethod()]
        [DataRow(1, 1, 2)]
        public void PlusTest(int number1, int number2, int expectedResult)
        {
            //Arrange
            int actualResult;
            Addition addition = new Addition();
            //Act
            actualResult = addition.Plus(number1, number2);
            //Assert
            Assert.AreEqual(actualResult, expectedResult);
        }
    }
}