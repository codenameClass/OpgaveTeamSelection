using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    public class BestStrategie : IStrategie
    {
        public bool ZoekVoorwaarde(Speler huidige, Speler vergelijking)
        {
            return (huidige.Rating < vergelijking.Rating);
        }
        public IAanvoerderVoorwaarde AanvoerderVoorwaarde { get; set; } = new AanvoerderHoogsteRating();
    }
}
