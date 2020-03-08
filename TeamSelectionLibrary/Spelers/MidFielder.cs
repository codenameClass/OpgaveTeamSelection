using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace TeamSelectionLibrary
{
    public class MidFielder : Speler
    {
        public MidFielder(string naam, int rugNummer, int rating, int caps, IEnumerable<MidFielderPosities> posities) : base(naam, rugNummer, rating, caps)
        {
            MogenlijkePosities = posities.ToList();
        }
        List<MidFielderPosities> MogenlijkePosities { get; set; }
        public override string ToString()
        {
            string temp="";
            foreach(MidFielderPosities entry in MogenlijkePosities)
            {
                temp += entry + " ";
            }
            return ($"{this.GetType().Name} - {Naam},{RugNummer} [Positions:{temp}] - Rating {Rating}, Caps {Caps}");
        }
    }
}
