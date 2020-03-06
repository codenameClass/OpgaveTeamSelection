using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace OpgaveTeamSelection
{
    public class Defender : Speler
    {
        public Defender(string naam,int rugNummer,int rating,int caps,IEnumerable<DefenderPosities> posities) : base(naam, rugNummer, rating, caps)
        {
            MogenlijkePosities = posities.ToList();
        }
        List<DefenderPosities> MogenlijkePosities { get; set; }
    }
}
