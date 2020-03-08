using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectionLibrary
{
    interface IAanvoerderVoorwaarde
    {
        Speler SelectAanvoerder(List<Speler> spelers);
    }
}
