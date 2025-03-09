using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bridge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.MCTests
{
    [TestClass()]
    public class MCTests
    {
        [TestMethod()]
        public void MCPriceReturns120()
        {
            //Arrange
            double expectedReturn = 120;
            MC mcReturn = new MC("1234567");
            bool broBizz = false;
            //Act

            //Assert
            Assert.AreEqual(mcReturn.Price(broBizz), expectedReturn);
        }

        [TestMethod()]
        [DataRow(true, 108)]
        [DataRow(false, 120)]
        public void DoesMCPriceReturnCorrectDiscount(bool broBizz, int expectedReturn)
        {
            //Arrange
            MC mcReturn = new MC("1234567");

            //Act

            //Assert
            Assert.AreEqual(mcReturn.Price(broBizz), expectedReturn);
        }


        [TestMethod()]
        public void TestMCClassVehicleTypeReturnsMC()
        {
            //Arrange
            MC mcReturn = new MC("1234567");
            string expectedReturn = "MC";
            //Act

            //Assert
            Assert.AreEqual(mcReturn.Vehicle(), expectedReturn);
        }
    }
}