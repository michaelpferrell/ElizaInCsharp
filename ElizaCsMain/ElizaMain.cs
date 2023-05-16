namespace ElizaCsMain
{
    public class ElizaMain
    {
        private const string _Eol = "\n";

        public string CurrentOutput
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

        public string LatestInput
        {
            get { return null; }
        }
    }
}