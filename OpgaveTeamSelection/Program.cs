using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace OpgaveTeamSelection
{
    public class Program
    {
        static string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\rodeDuivels.txt"); // Solution (werkt voor iedereen)
        //static string path = @"C:\Users\jensi\source\repos\OpgaveTeamSelectionMain\OpgaveTeamSelection\Resources\rodeDuivels.txt";      // Jens solution locatie
        //static string path = @"D:\Programmeren Data en Bestanden\rodeDuivels.txt";                                                      // Sven desktop locatie
        //static string path = @"D:\Programmeren Data en Bestanden\rodeDuivels.txt";                                                      // Sven laptop locatie
        //static string path = @"C:\Users\Sieglinde\OneDrive\voetbal\rodeDuivels.txt"                                                     // Sieglinde locatie 

        static void Main(string[] args)
        {
            //Load
            List<string> lijnen = FileProcessor.ReadFile(path);

            //Create
            Team team = new Team() { TeamNaam = "Rode Duivels" };
            IPlayerFactory pf = new PlayerFactory(team);

            //Read
            foreach(string lijn in lijnen)
            {
                team.VoegSpelerToe(pf.MaakSpeler(lijn));
            }

            //Print
            Selectie selectie1 = team.SelectieAanmaken(4, 4, 2, new BestStrategie());
            selectie1.PrintSelectie();

        }
    }
}
