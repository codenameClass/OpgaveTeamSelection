using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    public interface IPlayerFactory
    {
        public Speler MaakSpeler(string spelerInfo);
    }
}
