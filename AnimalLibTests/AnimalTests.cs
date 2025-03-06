using Microsoft.VisualStudio.TestTools.UnitTesting;
using AnimalLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalLib.UnitTestOfAnimal
{
    [TestClass()]
    public class AnimalTests
    {
        //Arrange
        Animal animal = new Animal(1, "Mammal", 10, 1500);
        //Okay, vi skal teste om vores properties virker som de skal.
        //Prisen skal være over 10 og under 10000.
        //Category skal være mindst 3 karakterer lang.
        [TestMethod()]
        [DataRow("abc")]
        [DataRow("abcd")]
        [DataRow("Hello World")]
        public void CategoryLengthMoreThanTwo(string categoryLength)
        {
            //We need to rewrite this to test whether we can create an animal object, with too short a category.
            //Arrange

            string actualLength = categoryLength;
            int expectedLength = actualLength.Length;
            //Act

            //Assert
            Assert.IsTrue(actualLength.Length > 2);
        }

        [TestMethod]
        [DataRow("")]
        [DataRow("a")]
        [DataRow("ab")]
        public void CategoryLengthTwoOrLess(string categoryLength)
        {
            //Arrange
            //Act
            //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => animal.Category = categoryLength);
        }

        [TestMethod()]
        [DataRow(10)]
        [DataRow(8)]
        [DataRow(4)]
        public void PriceCannotBeLessthanEleven(double price)
        {

            Assert.IsTrue(price <= 10);
        }
    }
}