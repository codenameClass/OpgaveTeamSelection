using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace OpgaveTeamSelection
{
    public class MidFielder : Speler
    {
        public MidFielder(string naam, int rugNummer, int rating, int caps, IEnumerable<MidFielderPosities> posities) : base(naam, rugNummer, rating, caps)
        {
            MogenlijkePosities = posities.ToList();
        }
        List<MidFielderPosities> MogenlijkePosities { get; set; }
    }
}
