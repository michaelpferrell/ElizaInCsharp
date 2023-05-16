﻿namespace ElizaCsMain
{
    public class ElizaMain
    {
        private const string _Eol = "\n";
        private string _CurrentOutput;
        private string _LatestInput = null;

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
                return _LatestInput.Contains("SHUT");
            }
        }

        public void UseInput(string UserInputIn)
        {
            _LatestInput = UserInputIn;
            if (UserSaidToEnd)
            {
                ShutUp();
                return;
            }
            _CurrentOutput = "WE WERE DISCUSSING YOU-- NOT ME.";
        }

        private void ShutUp()
        {
            _CurrentOutput = "SHUT UP...";
        }
    }
}