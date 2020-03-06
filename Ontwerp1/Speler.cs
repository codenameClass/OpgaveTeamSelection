using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    public class Speler : ISpeler
    {   public Speler(string naam,int rugNummer,int rating,int caps)
        {
            Naam = naam;
            RugNummer = rugNummer;
            Rating = rating;
            Caps = caps;
            Geblesseerd = false;
        }
        public int RugNummer { get; set; }
        public int Rating { get; set; }
        public int Caps { get; set; }
        public bool Geblesseerd { get; set; }
        public Team Team { get; set; }
    }
}
