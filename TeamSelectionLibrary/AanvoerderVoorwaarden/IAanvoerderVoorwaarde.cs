using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectionLibrary
{
    public interface IAanvoerderVoorwaarde
    {
        Speler SelectAanvoerder(List<Speler> spelers);
    }
}
