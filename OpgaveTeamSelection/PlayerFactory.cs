﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpgaveTeamSelection
{
    public class PlayerFactory : IPlayerFactory
    {
        public Team Team { get; set; }

        public PlayerFactory(Team team) => Team = team;

        public Speler MaakSpeler(string spelerInfo)
        {
            //Setup
            string[] data = spelerInfo.Split(',');
            string naam = data[1];
            int rugNummer, rating, caps;

            //Validation
            bool rugNummerInput = int.TryParse(data[2],out rugNummer) && rugNummer > 0 && rugNummer <= 99;
            bool ratingInput = int.TryParse(data[data.Length-2], out rating) && rating >= 0 && rating <= 100;
            bool capsInput = int.TryParse(data[data.Length-1], out caps) && caps >= 0;
            List<bool> validationLogs = new List<bool>() { true, rugNummerInput, ratingInput, capsInput };

            //Return
            if (!validationLogs.Contains(false))
            {
                if (data[0] == "GoalKeeper") {
                    List<GoalKeeperPosities> temp = new List<GoalKeeperPosities>();
                    for(int i = 3; i < data.Length - 2; i++)
                    {
                        temp.Add((GoalKeeperPosities) Enum.Parse(typeof(GoalKeeperPosities), data[i]));
                    }
                    return new GoalKeeper(naam, rugNummer, rating, caps,temp);
                }
                else if (data[0] == "Forward")
                {
                    List<ForwardPosities> temp = new List<ForwardPosities>();
                    for (int i = 3; i < data.Length - 2; i++)
                    {
                        temp.Add((ForwardPosities)Enum.Parse(typeof(ForwardPosities), data[i]));
                    }
                    return new Forward(naam, rugNummer, rating, caps, temp);
                }
                else if (data[0] == "MidFielder")
                {
                    List<MidFielderPosities> temp = new List<MidFielderPosities>();
                    for (int i = 3; i < data.Length - 2; i++)
                    {
                        temp.Add((MidFielderPosities)Enum.Parse(typeof(MidFielderPosities), data[i]));
                    }
                    return new MidFielder(naam, rugNummer, rating, caps, temp);
                }
                else
                {
                    List<DefenderPosities> temp = new List<DefenderPosities>();
                    for (int i = 3; i < data.Length - 2; i++)
                    {
                        temp.Add((DefenderPosities)Enum.Parse(typeof(DefenderPosities), data[i]));
                    }
                    return new Defender(naam, rugNummer, rating, caps, temp);
                }
            }
            else
                throw new SpelerinfoException("Er zitten fouten in de spelerInfo string.", validationLogs);
        }
    }
}
