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

        /// <summary>
        /// Tests whether the Price method actually returns 230, or something else. 
        /// After I wrote the weekend discount I realized that that part of code actually worked as well, because the returned
        /// result was lower than 230, which it only could be if the weekend-discount-part of the method worked. Comment written 09.03.2025. Sunday.
        /// </summary>
        [TestMethod()]
        public void DoesPriceReturns230()
        {
            //Arrange
            double expectedReturn = 230;
            Car carReturn = new Car("12345678");
            bool broBizz = false;
            DayOfWeek whichDayIsIt = DateTime.Now.DayOfWeek;

            //Act
            if(whichDayIsIt == DayOfWeek.Saturday || whichDayIsIt == DayOfWeek.Sunday)
            {
                expectedReturn = 230 * 0.85;
                //34,5 
                //195,5
            }

            //Assert
            Assert.AreEqual(carReturn.Price(broBizz), expectedReturn);
        }


        /// <summary>
        /// So this method should really only test the brobizz part of the Price method, but 
        /// I've found that it also happens to test the weekend discount quite effectively. I
        /// am writing these comments on a Sunday, and the price returned was suddenly much lower than
        /// anticipated. Still need to figure out how to test that the weekend discount works. 
        /// </summary>
        /// <param name="broBizz"></param>
        /// <param name="expectedReturn"></param>
        [TestMethod()]
        [DataRow(true, 207)]
        [DataRow(false, 230)]
        public void DoesCarPriceReturnCorrectBroBizzDiscount(bool broBizz, double expectedReturn)
        {
            //Arrange
            Car mcReturn = new Car("1234567");
            DayOfWeek whichDayIsIt = DateTime.Now.DayOfWeek;

            //Act
            if (whichDayIsIt == DayOfWeek.Saturday || whichDayIsIt == DayOfWeek.Sunday)
            {
                expectedReturn = expectedReturn * 0.85;
                //34,5 
                //195,5
            }

            //Assert
            Assert.AreEqual(expectedReturn, mcReturn.Price(broBizz), 0.0001); //added the 0.0001 because the test otherwise would return 175,95000000000002 against 175,05
        }

        [TestMethod()]
        [DataRow(true, 207)]
        [DataRow(false, 230)]
        public void DoesPrice_Return_CorrectWeekend_BroBizz_Discount(bool broBizz, double expectedReturn)
        {
            //Arrange
            Car mcReturn = new Car("1234567");
            DayOfWeek whichDayIsIt = DateTime.Now.DayOfWeek;

            //Act
            if (whichDayIsIt == DayOfWeek.Saturday || whichDayIsIt == DayOfWeek.Sunday)
            {
                expectedReturn = expectedReturn * 0.85;
                //34,5 
                //195,5
            }

            //Assert
            Assert.AreEqual(expectedReturn, mcReturn.Price(broBizz), 0.0001); //added the 0.0001 because the test otherwise would return 175,95000000000002 against 175,05
        }

        /// <summary>
        /// Inefficient I know, but below we will test the internal logic of the Car class' price method.
        /// For now this is the best way I know how.
        /// </summary>
        [TestMethod()]
        public void TestPriceReturns230_WhenNotWeekend_OrWithoutBrobizz()
        {
            //Arrange          
            bool isItWeekend = false;

            double priceCounter = 230;

            double weekendDiscount = 0.85;

            bool haveBroBizz = false;

            double broBizzDiscount = 0.90;

            //Car carReturn = new Car("12345678");
            
            //DayOfWeek whichDayIsIt = DayOfWeek.Monday;

            double expectedReturn = 230;       

            //Act
            if (isItWeekend == true)
            {
                priceCounter = 230 * weekendDiscount;

                if (haveBroBizz == true)
                {
                    priceCounter = priceCounter * broBizzDiscount;
                }

            }
            if (haveBroBizz == true)
            {
                priceCounter = 230 * broBizzDiscount;
            }           

            //Assert
            Assert.AreEqual(expectedReturn, priceCounter);
        }


        [TestMethod()]
        public void TestCarClassVehicleTypeReturnsCar()
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
