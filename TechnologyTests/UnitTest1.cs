using Technology;
namespace TechnologyTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        public void TestDropPhone()
        {
            Smartphone patsPhone = new Smartphone(64, 8, "Android rules!");
            patsPhone.DropPhone();
            Assert.IsFalse(patsPhone.HasCamera);
        }

        [TestMethod]
        public void TestStuffedCheetos()
        {
            Laptop gerardsLaptop = new Laptop(4, 64, 16, "MacOS");
            gerardsLaptop.StuffedCheetos(2);
            Assert.AreEqual(2, gerardsLaptop.NumOfUsb, .001);
        }
    }
}