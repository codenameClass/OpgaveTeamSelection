using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectionLibrary
{
    public abstract class Strategie : Comparer<Speler>
    {
        public abstract IAanvoerderVoorwaarde AanvoerderVoorwaarde { get; set; }

    }
}
