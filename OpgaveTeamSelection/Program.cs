using System;
using System.Collections.Generic;

namespace OpgaveTeamSelection
{
    public class Program
    {
        static void Main(string[] args)
        {   List<string> lijnen = FileProcessor.ReadFile(@"D:\Programmeren Data en Bestanden\rodeDuivels.txt");     //Sven desktop locatie
            //List<string> lijnen = FileProcessor.ReadFile(@"C:\TeamOpdracht\rodeDuivels.txt");             //sven laptop locatie
            //List<string> lijnen = FileProcessor.ReadFile(@"C:\Users\Sieglinde\OneDrive\voetbal\rodeDuivels.txt");  //Sieglinde locatie 
            Team team = new Team();
            team.TeamNaam = "Rode Duivels";
            IPlayerFactory pf = new PlayerFactory(team);
            foreach(string lijn in lijnen)
            {
                pf.MaakSpeler(lijn);
            }
            Selectie selectie1 = team.SelectieAanmaken(4, 4, 2, new BestStrategie());
            selectie1.PrintSelectie();

        }
    }
}
