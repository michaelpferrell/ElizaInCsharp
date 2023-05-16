//See Eliza in David Ahl's _More_Basic_Computer_Games_
//E.g.: https://www.atariarchives.org/morebasicgames/showpage.php?page=56
using ElizaCsMain;
using System.Security.Cryptography.X509Certificates;

namespace Test_ElizaCsMain
{
    [TestClass]
    public class Test_ElizaMain_New
    {
        private const string _Eol = "\n";
        private string _InitialOutput = 
                new string(' ', 26) + "ELIZA" + _Eol +
                new string(' ', 20) + "CREATIVE COMPUTING" + _Eol +
                new string(' ', 18) + "MORRISTOWN, NEW JERSEY" + _Eol + _Eol + _Eol +
                "HI!  I'M ELIZA.  WHAT'S YOUR PROBLEM?";
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

        [TestMethod]
        public void Test_CurrentOutput()
        {
            Assert.AreEqual(_InitialOutput, _Main.CurrentOutput);
        }

        [TestMethod]
        public void Test_LatestInput()
        {
            Assert.IsNull(_Main.LatestInput);
        }
    }
}