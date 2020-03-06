using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    public interface IAanvoerderVoorwaarde
    {
        public Speler SelectAanvoerder(List<Speler> spelers);
    }
}
