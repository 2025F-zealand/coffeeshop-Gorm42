using Microsoft.VisualStudio.TestTools.UnitTesting;
using NyAktieHandelRepoLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NyAktieHandelRepoLib.Tests
{
    [TestClass()]
    public class AktieHandelTests
    {
        [TestMethod()]
        [DataRow("1234")]
        [DataRow("12345")]
        [DataRow("123456")]
        public void AktieHandelNavn_Should_WorkWithValue_4_Or_Greater(string name)
        {
            //arrange
            Aktiehandel aktie = new Aktiehandel(name, 10, 150);

            //Act

            //Arrange
            Assert.IsTrue(aktie.AktieNavn.Length >= 4);

        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))] //Testen består hvis den fejler. Hmm. microsoft learn anbefaler ikke man bruger den her...
        [DataRow("123")]                                                                        //https://stackoverflow.com/questions/8744825/checking-if-argument-is-thrown-in-unit-tests hmm her siger de god.
        [DataRow("12")]
        [DataRow("1")]
        [DataRow("")]
        public void AktieHandelNavn_Should_NotWorkWithValue_3_Or_Less(string name)
        {
            //Arrange
            Aktiehandel aktie = new Aktiehandel(name, 10, 150);

            //neither act or arrange are needed. due to the ExpectedException outside the method name.
          

        }
    }
}