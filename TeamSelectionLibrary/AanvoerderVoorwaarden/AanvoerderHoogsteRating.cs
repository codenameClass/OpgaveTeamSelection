using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectionLibrary
{
    class AanvoerderHoogsteRating : IAanvoerderVoorwaarde
    {
        public Speler SelectAanvoerder(List<Speler> spelers)
        {
            int index = 0;
            for (int i = 1; i < spelers.Count; i++)
            {
                if (spelers[index].Rating < spelers[i].Rating)
                    index = i;
            }
            return spelers[index];
        }
    }
}
