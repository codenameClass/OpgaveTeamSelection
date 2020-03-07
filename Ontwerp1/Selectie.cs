using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OpgaveTeamSelection
{
    public class Selectie
    {
        public Speler Aanvoerder { get; set; }
        public List<Speler> GeselecteerdeSpelers { get; set; }
        public List<Defender> Defenders => GeselecteerdeSpelers.Where(s => s is Defender).Select(s => (Defender)s).ToList();
        public List<MidFielder> MidFielders => GeselecteerdeSpelers.Where(s => s is MidFielder).Select(s => (MidFielder) s).ToList();
        public List<Forward> Forwards => GeselecteerdeSpelers.Where(s => s is Forward).Select(s => (Forward)s).ToList();
        public List<GoalKeeper> GoalKeeper => GeselecteerdeSpelers.Where(s => s is GoalKeeper).Select(s => (GoalKeeper)s).ToList();

        public Selectie(List<Speler> geselecteerdeSpelers, Speler aanvoerder)
        {
            if(geselecteerdeSpelers.Count != 11) throw new ArgumentException("Het SpelerAantal is niet gelijk aan 11");

            GeselecteerdeSpelers = geselecteerdeSpelers;
            Aanvoerder = aanvoerder;
        }
        
        public void PrintSelectie()
        {
            foreach (Defender defender in Defenders)
            {
                if(defender == Aanvoerder)
                {
                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.WriteLine(defender);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else Console.WriteLine(defender);
            }
            foreach(MidFielder midfielder in MidFielders)
            {
                if (midfielder == Aanvoerder)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(midfielder);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else Console.WriteLine(midfielder);
            }
            foreach(Forward forward in Forwards)
            {
                if(forward == Aanvoerder)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(forward);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else Console.WriteLine(forward);

            }
            if (GoalKeeper[0] == Aanvoerder)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(GoalKeeper[0]);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else Console.WriteLine(GoalKeeper[0]);
        }
    }
}
