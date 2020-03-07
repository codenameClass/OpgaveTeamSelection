using System;
using System.Collections.Generic;

namespace OpgaveTeamSelection
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> lijnen = FileProcessor.ReadFile(@"C:\TeamOpdracht\rodeDuivels.txt");
            Team team = new Team();
            team.TeamNaam = "Rode Duivels";
            IPlayerFactory pf = new PlayerFactory(team);
            foreach(string lijn in lijnen)
            {
                pf.MaakSpeler(lijn);
            }
            team.SelectieAanmaken(4, 4, 2, new BestStrategie());

        }
    }
}
