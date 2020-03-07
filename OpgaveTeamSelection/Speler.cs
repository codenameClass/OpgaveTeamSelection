using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    public class Speler : ISpeler
    {  
        public int RugNummer { get; set; }
        public string Naam { get; set; }
        public int Rating { get; set; }
        public int Caps { get; set; }
        public bool Geblesseerd { get; set; }
        public Team Team { get; set; }

        public Speler(string naam, int rugNummer, int rating, int caps)
        {
            Naam = naam;
            RugNummer = rugNummer;
            Rating = rating;
            Caps = caps;
            Geblesseerd = false;
        }
        
        public override bool Equals(object obj)
        {
            if (obj is Speler)
            {
                Speler temp = obj as Speler;
                return temp.Naam == Naam 
                    && temp.RugNummer == RugNummer
                    && Rating == temp.Rating
                    && Caps == temp.Caps
                    && Geblesseerd == temp.Geblesseerd
                    && Team == temp.Team;
            }
            else return false;
        }
        public override int GetHashCode() => Naam.GetHashCode() ^ RugNummer.ToString().GetHashCode();
    }
}
