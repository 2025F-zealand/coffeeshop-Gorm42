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
            Car carReturn = new Car();
            
            //Act

            //Assert
            Assert.AreEqual(carReturn.Price(), expectedReturn);
        }

        [TestMethod()]
        public void TestVehicleReturnsMC()
        {
            //Arrange
            Car carReturn = new Car();
            string expectedReturn = "Car";
            //Act


            //Assert
            Assert.AreEqual(carReturn.VehicleType(), expectedReturn);
        }
    }


}

namespace BridgeTests
{
    class CarTests
    {
    }
}
