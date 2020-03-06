using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OpgaveTeamSelection
{
    public class SelectieOpvuller
    {
        public static Selectie VulSelectieOp(int aantalDefenders, int aantalMidfielders, int aantalForwards, List<Speler> spelers, IStrategie strategie)
        {
            for (int x = 0; x < spelers.Count - 1; x++)
            {
                int ind = x;
                for (int i = x + 1; i < spelers.Count; i++)
                {
                    if (strategie.ZoekVoorwaarde(spelers[ind], spelers[i]))
                        ind = i;
                }
                Speler tussenwaarde = spelers[x];
                spelers[x] = spelers[ind];
                spelers[ind] = tussenwaarde;
            }

            List<Defender> defenders = new List<Defender>();
            List<MidFielder> midfielders = new List<MidFielder>();
            List<Forward> forwards = new List<Forward>();
            List<GoalKeeper> goalkeeper = new List<GoalKeeper>();

            int index = 0;
            List<Speler> geselecteerdeSpelers = new List<Speler>();
            do
            {
                if (spelers[index] is Defender && defenders.Count < aantalDefenders)
                {
                    defenders.Add(spelers[index] as Defender);
                    geselecteerdeSpelers.Add(spelers[index]);
                }
                else if (spelers[index] is MidFielder && midfielders.Count < aantalMidfielders)
                {
                    midfielders.Add(spelers[index] as MidFielder);
                    geselecteerdeSpelers.Add(spelers[index]);
                }
                else if (spelers[index] is Forward && forwards.Count < aantalForwards)
                {
                    forwards.Add(spelers[index] as Forward);
                    geselecteerdeSpelers.Add(spelers[index]);
                }
                else if (spelers[index] is GoalKeeper && goalkeeper.Count < 1)
                {
                    goalkeeper.Add(spelers[index] as GoalKeeper);
                    geselecteerdeSpelers.Add(spelers[index]);
                }

                index++;
            } while (defenders.Count != aantalDefenders && midfielders.Count != aantalMidfielders && forwards.Count != aantalForwards && goalkeeper.Count != 1);

            return new Selectie(defenders, midfielders, forwards, goalkeeper, strategie.AanvoerderVoorwaarde.SelectAanvoerder(geselecteerdeSpelers));
        }
    }


    public class MyComparer : IComparer<Object>
    {

        public int Compare(Object stringA, Object stringB)
        {
            String[] valueA = stringA.ToString().Split('/');
            String[] valueB = stringB.ToString().Split('/');

            if (valueA.Length != 2 || valueB.Length != 2)
                return String.Compare(stringA.ToString(), stringB.ToString());

            if (valueA[0] == valueB[0])
            {
                return String.Compare(valueA[1], valueB[1]);
            }
            else
            {
                return String.Compare(valueA[0], valueB[0]);
            }

        }
    }
}
