using Microsoft.VisualStudio.TestTools.UnitTesting;
using AktieHandelRepositoryLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AktieHandelRepositoryLib.RepositoryClassUnitTests
{
    [TestClass()]
    public class AktieHandelRepositoryTests
    {
        //Private field to use in Unit Tests
        private List<Aktie> AktieListe;
        //Aktie object to be used in Unit Tests
        Aktie testAktie1 = new Aktie(1, "Apple", 10, 150);
        Aktie testAktie2 = new Aktie(2, "Novo", 15, 200);
        Aktie testAktie3 = new Aktie(3, "Maersk", 20, 250);


        [TestMethod()]
        public void GetAktieByIdTest()
        {
            int expectedId = 1;
            int actualId = testAktie1.HandelsId;
            Assert.AreEqual(expectedId, actualId);
        }


        //Hmm, i tvivl om hvordan jeg skal løse denne.
        [TestMethod()]
        public void GetAllAktier_Aktieliste()
        {
            //Arrange
            AktieListe.Add(testAktie1);
            AktieListe.Add(testAktie2);
            AktieListe.Add(testAktie3);
            Aktie firstAktie = AktieListe[0];
            Aktie secondAktie = AktieListe[1];
            Aktie thirdAktie = AktieListe[2];
            //Act

            //Assert
            Assert.IsTrue(AktieListe.Contains(secondAktie));
        }

        [TestMethod()]
        public void GetAktieTest()
        {
            Assert.Fail();
        }


        // https://stackoverflow.com/questions/24773416/how-to-unittest-a-method-that-recieve-and-return-a-list-of-objects
        [TestMethod()]
        [DataRow(1, 5)]
        [DataRow(2, 10)]
        [DataRow(3, 8)]
        public void AddNewIdToAktie1_2_3(int oldId, int newId)
        {
            //Arrange
            Aktie aktie = new Aktie(oldId, "Apple", 10, 150);

            //Act
            aktie.HandelsId = newId;

            //Assert
            Assert.AreEqual(newId, aktie.HandelsId);
        }

        [TestMethod()]
        public void DeleteAktieTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void UpdateAktieTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GenerateIdTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void AddAktieAktieListeTest()
        {
            Assert.Fail();
        }
    }
}