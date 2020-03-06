using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace OpgaveTeamSelection
{
    public class GoalKeeper : Speler
    {
        public GoalKeeper(string naam, int rugNummer, int rating, int caps, IEnumerable<GoalKeeperPosities> posities) : base(naam, rugNummer, rating, caps)
        {
            MogenlijkePosities = posities.ToList();
        }
        List<GoalKeeperPosities> MogenlijkePosities { get; set; }
        public override string ToString()
        {
            string temp = "";
            foreach (GoalKeeperPosities entry in MogenlijkePosities)
            {
                temp += entry + " ";
            }
            return ($"{this.GetType().Name} - {Naam},{RugNummer} [Positions: ] - Rating {Rating}, Caps {Caps}");
        }
    }
}
