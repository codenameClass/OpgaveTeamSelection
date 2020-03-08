using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    public interface IStrategie
    {
        bool ZoekVoorwaarde(Speler huidige, Speler vergelijking);

        IAanvoerderVoorwaarde AanvoerderVoorwaarde { get; set; }

    }
}
