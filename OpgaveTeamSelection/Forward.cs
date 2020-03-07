using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace OpgaveTeamSelection
{
    public class Forward : Speler
    {
        public Forward(string naam, int rugNummer, int rating, int caps, IEnumerable<ForwardPosities> posities) : base(naam, rugNummer, rating, caps)
        {
            MogenlijkePosities = posities.ToList();
        }
        List<ForwardPosities> MogenlijkePosities { get; set; }
        public override string ToString()
        {
            string temp = "";
            foreach (ForwardPosities entry in MogenlijkePosities)
            {
                temp += entry + " ";
            }
            return ($"{this.GetType().Name} - {Naam},{RugNummer} [Positions:{temp}] - Rating {Rating}, Caps {Caps}");
        }
    }
}
