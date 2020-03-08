using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectionLibrary
{
    public class RotatieStrategie : Strategie
    {
        public override int Compare(Speler x, Speler y)
        {
            //Null is gelijk aan null...
            if (ReferenceEquals(x, null) && ReferenceEquals(y, null)) return 0;

            //Alles is groter dan null...
            if (ReferenceEquals(x, null)) return -1;
            if (ReferenceEquals(y, null)) return 1;

            return -(x.Caps.CompareTo(y.Caps));
        }

        public override IAanvoerderVoorwaarde AanvoerderVoorwaarde { get; set; } = new AanvoerderHoogsteCaps();
    }
}
