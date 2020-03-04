using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace OpgaveTeamSelection
{
    class Forward : Speler
    {
        public Forward(string naam, int rugNummer, int rating, int caps, IEnumerable<ForwardPosities> posities) : base(naam, rugNummer, rating, caps)
        {
            MogenlijkePosities = posities.ToList();
        }
        List<ForwardPosities> MogenlijkePosities { get; set; }
    }
}
