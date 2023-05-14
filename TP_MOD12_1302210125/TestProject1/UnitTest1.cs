using TP_MOD12_1302210125;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Form1 test = new Form1;
            int input = 5;
            string expectedOutput = "Positif";

            string output = CTB.CariTandaBilangan(input);
            Assert.AreEqual(expectedOutput, output);
        }
    }
}