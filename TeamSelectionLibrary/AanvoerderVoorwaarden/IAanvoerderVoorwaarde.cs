using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectionLibrary
{
    public interface IAanvoerderVoorwaarde
    {
        public Speler SelectAanvoerder(List<Speler> spelers);
    }
}
