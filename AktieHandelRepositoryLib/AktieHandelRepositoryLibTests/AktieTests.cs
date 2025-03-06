using Microsoft.VisualStudio.TestTools.UnitTesting;
using AktieHandelRepositoryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AktieHandelRepositoryLib.Tests
{
    [TestClass()]
    public class AktieTests
    {
        /// <summary>
        /// Okay, så problemer med Arrange, act og assert er at du nogle gange
        /// arrangerer i dit DataRow eller helt uden for TestMethod, hvorfor den
        /// traditionelle tredeling faktisk ikke fungerer inde i Unit Testing men også 
        /// rundt om.
        /// Tag AktieTest f.eks. Der arrangerer vi og act'er i samme linje og dernæst har
        /// vi så assert. Så jo, der er en formel på det her, men det er sgu slet ikke
        /// så firkanet som de der tre A'er får det til at se ud til.
        /// De tre A'er er mere en god tommelfingerregel. 
        /// </summary>
        Aktie aktie = new Aktie(1, "Apple", 10, 100);
        Aktie aktie2 = new Aktie(250, "Novo", 15, 150);
        Aktie aktie3 = new Aktie(3, "Maersk", 25, 200);
        
        //Her tester vi at vi kan oprette en aktie
        [TestMethod()]
        public void LavEtAktieObjekt()
        {
            Aktie aktie = new Aktie(1, "Apple", 10, 100);

            Assert.IsNotNull(aktie);
        }

        //Her tester vi at HandelsId kan være 1 eller større
        [TestMethod()]
        [DataRow(1)]
        public void HandelsIdTest(int id)
        {
            //Arrange
            int expected = id;
            //aktie.HandelsId = id;
            int actual = aktie.HandelsId;
            //Act
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        [DataRow(250)]
        [DataRow(1)]
        [DataRow(3)]
        [DataRow(57)]
        public void HandelsIdKanVæreEnEllerStørre(int id)
        {
            //Arrange
            int expectedId = id;

            aktie.HandelsId = id;

            int actualId = aktie.HandelsId;

            //Act
            //Assert
            Assert.AreEqual(expectedId, actualId);
        }

        //Her tester vi at HandelsId ikke kan være 0 eller mindre
        [TestMethod()]
        [DataRow(0)]
        [DataRow(-1)]
        [DataRow(int.MinValue)]
        public void HandelsIdKanVæreNulEllerMindre(int id)
        {
            //Arrange
            //Act
            //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => aktie.HandelsId = id);

        }

        //Ækvivalenspartition.
        //Her tester vi at Aktie.Antal kan være 1 eller mere
        [TestMethod()]
        [DataRow(10)]
        //[DataRow(int.MaxValue)]
        public void AktieAntalKanVæreEnEllerMere(int expectedAntal)
        {
            //Arrange
            int actualAntal = aktie.Antal;
            //Act
            //Assert
            Assert.AreEqual(actualAntal, expectedAntal);

        }

        //Her tester vi at Aktie.Antal ikke kan være 0 eller mindre
        [TestMethod()]
        [DataRow(0)]
        [DataRow(-1)]
        public void Antal_KanIkkeVære_0EllerMindre(int antal)
        {
            //Arrange
            //Act
            //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => aktie.Antal = antal);
        }

        //Her tester vi at Aktie.Navn kan være 4 eller mere tegn.
        [TestMethod()]
        [DataRow("Test")]
        [DataRow("Apple")]
        [DataRow("NovoNordisk")]
        [DataRow("Microsoft")]
        public void Navn_KanVære_FireTegn_EllerMere(string name)
        {
            //Arrange
            string nameLength = name;
            //Act
            //Assert
            //Vi skal vel asserte om længeden af det indsatte er lige med 4 eller mere? Så noget name.length >= 4
            Assert.IsTrue(nameLength.Length >= 4);
        }

        //Her tester vi at Aktie.Navn ikke kan være mindre end 4 tegn.
        [TestMethod()]
        [DataRow("Tes")]
        [DataRow("A")]
        [DataRow("Ny")]
        [DataRow("")]
        public void Navn_KanIkkeVære_Mindre_EndFire(string name)
        {
            //Arrange
            //string nameLength = name;
            //Act
            //Assert
            //Forstår ikke helt => aktie.AktieNavn = name her. Er det fordi 
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => aktie.AktieNavn = name);
        }


        //Test af pris
        [TestMethod]
        public void TestAfPris_Aktie2_Er150()
        {
            //Arrange
            decimal expectedPris = 150;
            decimal actualPris = aktie2.Pris;
            //Act
            //Assert
            Assert.AreEqual(expectedPris, actualPris);
        }

        //Test af pris ikke kan være 0 eller mindre. Så en throw exception<ArgumentOutOfRangeException>
        [TestMethod]
        [DataRow(0)]
        [DataRow(-1)]
        public void TestAfPrisMinus(int pris)
        {
            //Arrange
            //Act
            //Assert
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => aktie.Pris = pris);

        }
    }
}