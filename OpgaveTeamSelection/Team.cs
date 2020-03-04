using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    class Team
    {
        public List<Speler> Spelers { get; set; }
        public string TeamNaam { get; set; }

        public Selectie SelectieAanmaken(int aantalDefenders, int aantalMidfielders, int aantalForwarders, Strategieën strategie)
        {
            

        }
        public void VoegSpelerToe(Speler speler)
        {
            //Moeten we hier testen of de speler er al in zit? 
            //Moeten we zorgen dat de speler dan uit zijn eigen team verwijderd wordt? 

            Spelers.Add(speler);
            speler.Team = this;
        }
        public void VerwijderSpeler(Speler speler)
        {
            //Testen of de speler wel echt in het team zit. 

            Spelers.Remove(speler);
            speler.Team = null;
        }

    }
}
