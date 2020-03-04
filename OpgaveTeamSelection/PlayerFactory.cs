using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    class PlayerFactory : IPlayerFactory
    {
        public Team Team { get; set; }

        public PlayerFactory(Team team) => Team = team;

        public Speler MaakSpeler(string spelerInfo)
        {
            string[] data = spelerInfo.Split(',');
            string naam = data[0];
            int rugNummer, rating, caps;
            bool rugNummerInput = int.TryParse(data[1],out rugNummer) && rugNummer > 0 && rugNummer <= 99;
            bool ratingInput = int.TryParse(data[2], out rating) && rating >= 0 && rating <= 100;
            bool capsInput = int.TryParse(data[3], out caps) && caps >= 0;
            if (rugNummerInput && ratingInput && capsInput)
                return new Speler(naam, rugNummer, rating, caps);
            else
                return null //TODO throw new Exception();
        }
    }
}
