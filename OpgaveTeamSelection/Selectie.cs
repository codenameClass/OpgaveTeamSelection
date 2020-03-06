using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    public class Selectie
    {
        public Selectie(List<Defender> defenders,List<MidFielder> midfielders,List<Forward>forwards,List<GoalKeeper> goalKeepers,Speler aanvoerder)
        {
            if ((defenders.Count + midfielders.Count + forwards.Count + goalKeepers.Count) != 11)
                throw new ArgumentException("Het SpelerAantal is niet gelijk aan 11");
            Defenders = defenders;
            MidFielders = midfielders;
            Forwards = forwards;
            GoalKeeper = goalKeepers;
            Aanvoerder = aanvoerder;
        }
        public Speler Aanvoerder { get; set; }
        public List<Defender> Defenders { get; set; }
        public List<MidFielder> MidFielders { get; set; }
        public List<Forward> Forwards { get; set; }
        public List<GoalKeeper> GoalKeeper { get; set; }
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
