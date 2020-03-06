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
    }
}
