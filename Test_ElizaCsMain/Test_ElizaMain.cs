//See Eliza in David Ahl's _More_Basic_Computer_Games_
//E.g.: https://www.atariarchives.org/morebasicgames/showpage.php?page=56
using ElizaCsMain;

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


    [TestClass]
    public class Test_ElizaMain_InitialInput_You
    {
        private ElizaMain _Main;
        private string _UserInput = "YOU";
        private string _ExpectedOutput = "WE WERE DISCUSSING YOU-- NOT ME.";

        [TestInitialize]
        public void SetUp()
        {
            _Main = new ElizaMain();
            _Main.UseInput(_UserInput);
        }

        [TestMethod]
        public void Test_CurrentOutput()
        {
            Assert.AreEqual(_ExpectedOutput, _Main.CurrentOutput);
        }

        [TestMethod]
        public void Test_LatestInput()
        {
            Assert.AreEqual(_UserInput, _Main.LatestInput);
        }
    }

    [TestClass]
    public class Test_ElizaMain_Shut
    {
        private ElizaMain _Main;
        private string _UserInput = "WILL YOU SHUT UP";
        private string _ExpectedOutput = "SHUT UP...";

        [TestInitialize]
        public void SetUp()
        {
            _Main = new ElizaMain();
            _Main.UseInput(_UserInput);
        }

        [TestMethod]
        public void Test_CurrentOutput()
        {
            Assert.AreEqual(_ExpectedOutput, _Main.CurrentOutput);
        }

        [TestMethod]
        public void Test_LatestInput()
        {
            Assert.AreEqual(_UserInput, _Main.LatestInput);
        }

        [TestMethod]
        public void Test_UserSaidToEnd()
        {
            Assert.IsTrue(_Main.UserSaidToEnd);
        }
    }
}