using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    public class Rotatiestrategie
    {
        Selectie MaakSelectie(int aantalDefenders, int aantalMidfielders, int aantalForwards, List<Speler> spelers)
        {

            for (int x = 0; x < spelers.Count - 1; x++)
            {
                int ind = x;
                for (int i = x + 1; i < spelers.Count; i++)
                {
                    if (spelers[ind].Caps > spelers[i].Caps)
                        ind = i;
                }
                Speler tussenwaarde = spelers[x];
                spelers[x] = spelers[ind];
                spelers[ind] = tussenwaarde;
            }

            return SelectieOpvuller.VulSelectieOp(aantalDefenders, aantalMidfielders, aantalForwards, spelers);
        }
    }
}
