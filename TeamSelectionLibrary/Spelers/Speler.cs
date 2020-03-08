using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace TeamSelectionLibrary
{
    public class Speler : ISpeler, IComparable, IComparable<Speler>
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

        public int CompareTo(object obj)
        {
            if (obj is Speler) return CompareTo(obj as Speler);
            else throw new ArgumentException($"Object must be of type {nameof(Speler)}.");
        }
        public int CompareTo(Speler andereSpeler)
        {
            if (!ReferenceEquals(andereSpeler, null))
            {
                int comparteTo = Naam.CompareTo(andereSpeler.Naam);
                if (comparteTo == 0) comparteTo = RugNummer.CompareTo(andereSpeler.RugNummer);
                return comparteTo;
            }
            else return +1;
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
