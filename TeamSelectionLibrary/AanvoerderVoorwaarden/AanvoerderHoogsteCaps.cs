using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectionLibrary
{
    class AanvoerderHoogsteCaps : IAanvoerderVoorwaarde
    {
        public Speler SelectAanvoerder(List<Speler> spelers)
        {
            int index = 0;
            for(int i=1;i<spelers.Count;i++)
            {
                if (spelers[index].Caps < spelers[i].Caps)
                    index = i;
            }
            return spelers[index];
        }
    }
}
