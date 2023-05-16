using ElizaCsMain;

namespace Test_ElizaCsMain
{
    [TestClass]
    public class Test_ElizaMain_New
    {
        private ElizaMain _Main;

        [TestInitialize]
        public void SetUp()
        {
            _Main = new ElizaMain();
        }

        [TestMethod]
        public void Test_Nullness()
        {
            Assert.IsNotNull(_Main);
        }
    }
}