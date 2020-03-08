using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace OpgaveTeamSelection
{
    public class Selectie
    {
        public Speler Aanvoerder { get; set; }
        public List<Speler> GeselecteerdeSpelers => (new List<Speler>()).Union(Defenders).Union(MidFielders).Union(Forwards).Union(GoalKeeper).ToList();
        public List<Defender> Defenders { get; set; }
        public List<MidFielder> MidFielders { get; set; }
        public List<Forward> Forwards { get; set; }
        public List<GoalKeeper> GoalKeeper { get; set; }

        public Selectie(List<Speler> geselecteerdeSpelers, Speler aanvoerder)
        {
            if(geselecteerdeSpelers.Count != 11) throw new ArgumentException("Het SpelerAantal is niet gelijk aan 11");

            Defenders = geselecteerdeSpelers.Where(s => s is Defender).Select(s => (Defender)s).ToList();
            MidFielders = geselecteerdeSpelers.Where(s => s is MidFielder).Select(s => (MidFielder)s).ToList();
            Forwards = geselecteerdeSpelers.Where(s => s is Forward).Select(s => (Forward)s).ToList();
            GoalKeeper = geselecteerdeSpelers.Where(s => s is GoalKeeper).Select(s => (GoalKeeper)s).ToList();
            Aanvoerder = aanvoerder;
        }
        
        public void PrintSelectie()
        {
            Console.WriteLine();
            Console.WriteLine("************************************************");
            foreach(Speler s in GeselecteerdeSpelers)
            {
                if(s == Aanvoerder)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(s);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else Console.WriteLine(s);
            }
            Console.WriteLine("************************************************");
            Console.WriteLine();
        }
        //public void PrintSelectie()
        //{
        //    foreach (Defender defender in Defenders)
        //    {
        //        if(defender == Aanvoerder)
        //        {
        //            Console.ForegroundColor= ConsoleColor.Blue;
        //            Console.WriteLine(defender);
        //            Console.ForegroundColor = ConsoleColor.White;
        //        }
        //        else Console.WriteLine(defender);
        //    }
        //    foreach(MidFielder midfielder in MidFielders)
        //    {
        //        if (midfielder == Aanvoerder)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Blue;
        //            Console.WriteLine(midfielder);
        //            Console.ForegroundColor = ConsoleColor.White;
        //        }
        //        else Console.WriteLine(midfielder);
        //    }
        //    foreach(Forward forward in Forwards)
        //    {
        //        if(forward == Aanvoerder)
        //        {
        //            Console.ForegroundColor = ConsoleColor.Blue;
        //            Console.WriteLine(forward);
        //            Console.ForegroundColor = ConsoleColor.White;
        //        }
        //        else Console.WriteLine(forward);

        //    }
        //    if (GoalKeeper[0] == Aanvoerder)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Blue;
        //        Console.WriteLine(GoalKeeper[0]);
        //        Console.ForegroundColor = ConsoleColor.White;
        //    }
        //    else Console.WriteLine(GoalKeeper[0]);
        //}
    }
}
