using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    public class Team2
    {
        public List<Speler> Spelers { get; set; } = new List<Speler>();
        public string TeamNaam { get; set; }

        public Selectie SelectieAanmaken(int aantalDefenders, int aantalMidfielders, int aantalForwards, Strategie2 strategie)
        {
            if (aantalDefenders + aantalForwards + aantalMidfielders == 10)
                return SelectieOpvuller2.VulSelectieOp(aantalDefenders, aantalMidfielders, aantalForwards, Spelers, strategie);
            else throw new ArgumentException("De Opstelling Bestaat niet uit 11 Spelers");

        }

        public void VoegSpelerToe(Speler speler)
        {
            if (!Spelers.Contains(speler))
            {
                Spelers.Add(speler);
                //speler.Team = this;
            }
            else throw new ArgumentException($"Deze speler bevindt zich al in het team: {speler}");

        }
        public void VerwijderSpeler(Speler speler)
        {
            //Testen of de speler wel echt in het team zit. 
            //hetzelfde: exception throwen als de speler niet tot een team toebehoort.
            Spelers.Remove(speler);
            speler.Team = null;
        }

    }
}
