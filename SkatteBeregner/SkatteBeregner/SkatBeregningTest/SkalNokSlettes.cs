namespace SkatBeregningTest
{
    [TestClass]
    public class SkatteBereningUnitTest
    {
        [TestMethod]
        [DataRow(0)] //skulle give 0 i skat
        [DataRow(18000)] //skulle give 10% eller Lav Skat
        [DataRow(22000)] //skulle give 20% eller Høj Skat
        public void BeregnSkat_Ingen_Lav_Høj_Special_SkatVirker(double value)
        {
            //Arrange

            //Act

            //Assert

        }


    }
}