namespace ElizaCsMain
{
    public class ElizaMain
    {
        private const string _Eol = "\n";
        private string _CurrentOutput;
        private string _LatestInput = null;
        private string _PreviousInput = null;

        public ElizaMain()
        {
            _CurrentOutput = InitialOutput;
        }

        private string InitialOutput
        {
            get
            {
                return
                        new string(' ', 26) + "ELIZA" + _Eol +
                        new string(' ', 20) + "CREATIVE COMPUTING" + _Eol +
                        new string(' ', 18) + "MORRISTOWN, NEW JERSEY" + _Eol + _Eol + _Eol +
                        "HI!  I'M ELIZA.  WHAT'S YOUR PROBLEM?";
            }
        }

        public string CurrentOutput
        {
            get
            {
                return _CurrentOutput;
            }
        }

        public string LatestInput
        {
            get { return _LatestInput; }
        }

        public bool UserSaidToEnd
        {
            get
            {
                return (_LatestInput != null) && (_LatestInput.Contains("SHUT"));
            }
        }

        public void UseInput(string UserInputIn)
        {
            _PreviousInput = _LatestInput;
            _LatestInput = UserInputIn;
            if (UserSaidToEnd)
            {
                _CurrentOutput = OutputForShut();
                return;
            }
            if ((_LatestInput != null) && (_LatestInput == _PreviousInput))
            {
                _CurrentOutput = OutputForRepeat();
                return;
            }
            if ((_LatestInput != null) && (_LatestInput.StartsWith("CAN YOU ")))
            {
                _CurrentOutput = OutputForCanYou();
                return;
            }
            _CurrentOutput = "WE WERE DISCUSSING YOU-- NOT ME.";
        }

        private string OutputForShut()
        {
            return "SHUT UP...";
        }

        private static string OutputForRepeat()
        {
            return "PLEASE DON'T REPEAT YOURSELF!";
        }

        private string OutputForCanYou()
        {
            string RestOfInput = _LatestInput.Substring("CAN YOU ".Length);
            string MyOutput = string.Format("DON'T YOU BELIEVE I CAN {0}", RestOfInput);
            return MyOutput;
        }

    }
}