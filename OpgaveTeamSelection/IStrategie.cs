using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    public interface IStrategie
    {
        Selectie MaakSelectie(int aantalDefenders, int aantalMidfielders, int aantalForwarders, List<Speler> spelers);

    }
}
