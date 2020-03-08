using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace TeamSelectionLibrary
{
    public class Defender : Speler
    {
        public Defender(string naam,int rugNummer,int rating,int caps,IEnumerable<DefenderPosities> posities) : base(naam, rugNummer, rating, caps)
        {
            MogenlijkePosities = posities.ToList();
        }
        List<DefenderPosities> MogenlijkePosities { get; set; }
        public override string ToString()
        {
            string temp = "";
            foreach (DefenderPosities entry in MogenlijkePosities)
            {
                temp += entry + " ";
            }
            return ($"{this.GetType().Name} - {Naam},{RugNummer} [Positions:{temp}] - Rating {Rating}, Caps {Caps}");
        }
    }
}
