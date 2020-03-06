using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    public class StandaardStrategie : IStrategie
    {
        public bool ZoekVoorwaarde(Speler huidige, Speler vergelijking)
        {
            return (huidige.Caps < vergelijking.Caps);
        }

        public IAanvoerderVoorwaarde AanvoerderVoorwaarde { get; set; } = new AanvoerderHoogsteCaps();
    }
}
