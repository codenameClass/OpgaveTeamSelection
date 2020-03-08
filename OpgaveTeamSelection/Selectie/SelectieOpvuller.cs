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
            SorteerOpStrategie(spelers, strategie);
            List<Speler> geselecteerdeSpelers = GetGeselecteerdeSpelers(aantalDefenders, aantalMidfielders, aantalForwards, spelers);

            return new Selectie(geselecteerdeSpelers, strategie.AanvoerderVoorwaarde.SelectAanvoerder(geselecteerdeSpelers));
        }
        private static void SorteerOpStrategie(List<Speler> spelers, IStrategie strategie)
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
        }
        private static List<Speler> GetGeselecteerdeSpelers(int aantalDefenders, int aantalMidfielders, int aantalForwards, List<Speler> spelers)
        {
            int index = 0;
            int defenderCounter = 0, midfielderCounter = 0, fowardCounter = 0, goalkeeperCounter = 0;
            List<Speler> geselecteerdeSpelers = new List<Speler>();
            do
            {

                Speler speler = spelers[index];
                if (speler is Defender && defenderCounter < aantalDefenders)
                {
                    geselecteerdeSpelers.Add(speler);
                    defenderCounter++;
                }
                else if (speler is MidFielder && midfielderCounter < aantalMidfielders)
                {
                    geselecteerdeSpelers.Add(speler);
                    midfielderCounter++;
                }
                else if (speler is Forward && fowardCounter < aantalForwards)
                {
                    geselecteerdeSpelers.Add(speler);
                    fowardCounter++;
                }
                else if (speler is GoalKeeper && goalkeeperCounter < 1)
                {
                    geselecteerdeSpelers.Add(speler);
                    goalkeeperCounter++;
                }
                index++;
            } while (defenderCounter != aantalDefenders || midfielderCounter != aantalMidfielders || fowardCounter != aantalForwards || goalkeeperCounter != 1);

            return geselecteerdeSpelers;
        }
    }
}
