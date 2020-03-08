using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TeamSelectionLibrary
{
    public class BestStrategie : IStrategie
    {
        public int Compare(Speler x, Speler y)
        {
            //Null is gelijk aan null...
            if (ReferenceEquals(x, null) && ReferenceEquals(y, null)) return 0;

            //Alles is groter dan null...
            if (ReferenceEquals(x, null)) return -1;
            if (ReferenceEquals(y, null)) return 1;

            return -(x.Rating.CompareTo(y.Rating));
        }

        public IAanvoerderVoorwaarde AanvoerderVoorwaarde { get; set; } = new AanvoerderHoogsteRating();
    }
}
