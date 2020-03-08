using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    class JICapsComparer : Comparer<Speler>
    {
        public override int Compare(Speler x, Speler y)
        {
            //Null is gelijk aan null...
            if (ReferenceEquals(x, null) && ReferenceEquals(y, null)) return 0;

            //Alles is groter dan null...
            if (ReferenceEquals(x, null)) return -1;
            if (ReferenceEquals(y, null)) return 1;

            return x.Caps.CompareTo(y.Caps);
        }
    }
}
