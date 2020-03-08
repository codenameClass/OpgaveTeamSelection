using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using TeamSelectionLibrary;

namespace OpgaveTeamSelection
{
    public class Program
    {
        static string PATH = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"Resources\rodeDuivels.txt");
        static void Main(string[] args)
        {
            //Load
            try
            {
                if (File.Exists(PATH))
                {
                    List<string> lijnen = FileProcessor.ReadFile(PATH);

                    //Create
                    Team team = new Team() { TeamNaam = "Rode Duivels" };
                    IPlayerFactory pf = new PlayerFactory();

                    //Read
                    for(int i = 0; i < lijnen.Count; i++)
                    {
                        try
                        {
                            team.VoegSpelerToe(pf.MaakSpeler(lijnen[i]));
                        }
                        catch(SpelerinfoException e)
                        {
                            Console.WriteLine($"error op regel {i+1} van het bronbestand:");
                            Console.WriteLine(e.Message);
                        }
                    }

                    //Print
                    Selectie selectie1 = team.SelectieAanmaken(4, 4, 2, new BestStrategie());
                    selectie1.PrintSelectie();
                    Selectie selectie2 = team.SelectieAanmaken(4, 4, 2, new RotatieStrategie());
                    selectie2.PrintSelectie();
                    Selectie selectie3 = team.SelectieAanmaken(4, 4, 2, new StandaardStrategie());
                    selectie3.PrintSelectie();

                }
                else throw new ArgumentException("Incorrect File Path");
            }
            catch (SpelerinfoException e)
            {
                Console.WriteLine(e.Message);
                foreach (KeyValuePair<string, bool> entry in e.Logs) Console.WriteLine($"{entry.Key}: {entry.Value} ");
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
