using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    public class SelectieOpvuller
    {
        public static Selectie VulSelectieOp(int aantalDefenders, int aantalMidfielders, int aantalForwards, List<Speler> spelers)
        {
            List<Defender> defenders = new List<Defender>();
            List<MidFielder> midfielders = new List<MidFielder>();
            List<Forward> forwards = new List<Forward>();
            List<GoalKeeper> goalkeeper = new List<GoalKeeper>();

            int index = 0;

            do
            {
                if (spelers[index] is Defender && defenders.Count < aantalDefenders)
                {
                    defenders.Add(spelers[index] as Defender);
                }
                else if (spelers[index] is MidFielder && midfielders.Count < aantalMidfielders)
                {
                    midfielders.Add(spelers[index] as MidFielder);
                }
                else if (spelers[index] is Forward && forwards.Count < aantalForwards)
                {
                    forwards.Add(spelers[index] as Forward);
                }
                else if (spelers[index] is GoalKeeper && goalkeeper.Count < 1)
                {
                    goalkeeper.Add(spelers[index] as GoalKeeper);
                }

                index++;
            } while (defenders.Count != aantalDefenders && midfielders.Count != aantalMidfielders && forwards.Count != aantalForwards && goalkeeper.Count != 1);

            return new Selectie(defenders, midfielders, forwards, goalkeeper, spelers[0]);
        }
    }
}
