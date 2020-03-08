using System;
using TeamSelectionLibrary;

namespace OpgaveTeamSelection
{
    public class TestSpelerinfoException
    {
        public void bar()
        {
            try
            {
                (new PlayerFactory()).MaakSpeler("test");
            }
            catch(SpelerinfoException e)
            {
                foreach (bool log in e.Logs.Values) Console.WriteLine(log);
            }
        }
    }
}
