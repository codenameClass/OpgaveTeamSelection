using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    public class Team
    {
        public List<Speler> Spelers { get; set; }
        public string TeamNaam { get; set; }

        public Selectie SelectieAanmaken(int aantalDefenders, int aantalMidfielders, int aantalForwards, IStrategie strategie)
        {
            //Hier trycatch voor aantal spelers moet 11 zijn. 
             return SelectieOpvuller.VulSelectieOp(aantalDefenders,aantalMidfielders, aantalForwards, Spelers, strategie);

        }
        
        public void VoegSpelerToe(Speler speler)
        {
            //Momenteel werken we met 1 team, later nog een exception throwen als de speler zich al in een team bevindt.
            //if (speler.Team == null)
            //{
                Spelers.Add(speler);
                speler.Team = this;
            //}

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
