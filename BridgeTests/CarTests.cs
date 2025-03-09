using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.CarTests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void TestPriceReturns230()
        {
            //Arrange
            double expectedReturn = 230;
            Car carReturn = new Car("12345678");
            bool broBizz = false;

            //Act

            //Assert
            Assert.AreEqual(carReturn.Price(broBizz), expectedReturn);
        }

        [TestMethod()]
        [DataRow(true, 207)]
        [DataRow(false, 230)]
        public void DoesMCPriceReturnCorrectDiscount(bool broBizz, int expectedReturn)
        {
            //Arrange
            Car mcReturn = new Car("1234567");

            //Act

            //Assert
            Assert.AreEqual(mcReturn.Price(broBizz), expectedReturn);
        }

        [TestMethod()]
        public void TestVehicleReturnsMC()
        {
            //Arrange
            Car carReturn = new Car("12345678");
            string expectedReturn = "Car";
            //Act


            //Assert
            Assert.AreEqual(carReturn.VehicleType(), expectedReturn);
        }


        [TestMethod()]
        [DataRow("123456")]
        [DataRow("12345")]
        [DataRow("1234")]
        public void TestLicensePlateIs7Characters(string licensePlate)
        {
            //Arrange
            Car carReturn = new Car("12345678");
            string testLicensePlate = licensePlate;
            //Act
            
            //Assert
            Assert.ThrowsException<ArgumentException>(() => carReturn.LicensePlate = testLicensePlate);
            //Assert.AreEqual(carReturn.LicensePlate, licensePlate);
        }

        [TestMethod()]
        [DataRow("NewLicensePlate1")]
        [DataRow("NewLicensePlate2")]
        [DataRow("NewLicensePlate3")]
        public void TestLicensePlateCanBeSet(string newLicensePlate)
        {
            //Arrange
            Car carReturn = new Car("1234567");

            //Act
            carReturn.LicensePlate = newLicensePlate;

            //Assert
            Assert.IsNotNull(carReturn);
        }
    }


}
