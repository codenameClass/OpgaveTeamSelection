using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    public abstract class Strategie2 : Comparer<Speler>
    {
        public abstract IAanvoerderVoorwaarde AanvoerderVoorwaarde { get; set; }

    }
}
