using System;

namespace OpgaveTeamSelection
{
    public class TestSpelerinfoException
    {
        public void bar()
        {
            try
            {
                (new PlayerFactory(new Team())).MaakSpeler("test");
            }
            catch(SpelerinfoException e)
            {
                foreach (bool log in e.Logs) Console.WriteLine(log);
            }
        }
    }
}
