using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Logging;
using SkatteBeregner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace SkatteBeregner.Tests
{
    [TestClass()]
    public class SkatteBeregningTests
    {
        SkatteBeregning placeholder = new SkatteBeregning();

        [TestMethod()]
        public void BeregnIngenSkatTest()
        {
            //Arrange
            Borger borger = new Borger("Jens", Borger.TypeAfBorger.Pensionist, 0);
            //Act
            double resultat = placeholder.BeregnSkat(borger.TypeBorger, borger.Indkomst);
            //Assert
            Assert.AreEqual(0, resultat);
        }

        [TestMethod()]
        public void BeregnLavSkatTest()
        {
            //Arrange
            Borger borger = new Borger("Liberal", Borger.TypeAfBorger.Studerende, 10000);
            //Act
            double resultat = placeholder.BeregnSkat(borger.TypeBorger, borger.Indkomst);
            //Assert
            Assert.AreEqual(1000, resultat);
        }

        [TestMethod()]
        public void BeregnHøjSkatTest()
        {
            //Arrange
            Borger borger = new Borger("Socialist", Borger.TypeAfBorger.Studerende, 21000);
            //Act
            double resultat = placeholder.BeregnSkat(borger.TypeBorger, borger.Indkomst);
            //Assert
            Assert.AreEqual(4200, resultat);
        }

        [TestMethod()]
        public void BeregnSpecialSkatTest()
        {
            //Arrange
            Borger borger = new Borger("Mærsk", Borger.TypeAfBorger.Pensionist, 5000);
            //Act
            double resultat = placeholder.BeregnSkat(borger.TypeBorger, borger.Indkomst);
            //Assert
            Assert.AreEqual(250, resultat);
        }

        [TestMethod()]
        [DataRow(0, 0)] // 0 = studerende
        [DataRow(1, 0)] // 1 = underviser
        [DataRow(2, 0)] // 2 = pensionist
        public void BeregnIngenSkatPåAlleTyperAfBorgerTest(int typeInt, double indkomst)
        {
            //Arrange
            //Typecast, fordi man ikke kan bruge enums i DataRow i så fald skulle det være DynamicData.
            Borger.TypeAfBorger type = (Borger.TypeAfBorger)typeInt;
            Borger borger = new Borger("Jørgen", type, indkomst);
            //Act
            double resultat = placeholder.BeregnSkat(borger.TypeBorger, borger.Indkomst);
            //Assert
            Assert.AreEqual(0, resultat);
        }
    }
}