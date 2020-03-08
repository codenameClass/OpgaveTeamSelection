using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectionLibrary
{
    public class Team
    {
        public List<Speler> Spelers { get; set; } = new List<Speler>();
        public string TeamNaam { get; set; }

        public Selectie SelectieAanmaken(int aantalDefenders, int aantalMidfielders, int aantalForwards, Strategie strategie)
        {
            if (aantalDefenders + aantalForwards + aantalMidfielders == 10)
                return SelectieOpvuller.VulSelectieOp(aantalDefenders, aantalMidfielders, aantalForwards, Spelers, strategie);
            else throw new ArgumentException("De Opstelling Bestaat niet uit 11 Spelers");

        }

        public void VoegSpelerToe(Speler speler)
        {
            if (!Spelers.Contains(speler))
            {
                Spelers.Add(speler);
                speler.Team = this;
            }
            else throw new ArgumentException($"Deze speler bevindt zich al in het team: {speler}");

        }
        public void VerwijderSpeler(Speler speler)
        {
            if (speler.Team == this)
            {
                Spelers.Remove(speler);
                speler.Team = null;
            }
            else throw new ArgumentException($" {speler.Naam} behoort niet tot dit team");
        }

    }
}
