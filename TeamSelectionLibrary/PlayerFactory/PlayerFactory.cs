using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamSelectionLibrary
{
    public class PlayerFactory : IPlayerFactory
    {
        public Speler MaakSpeler(string spelerInfo)
        {
            //Parameter check
            //if (spelerInfo == null) throw Exception("spelerInfo is null");

            //Setup
            string[] data = spelerInfo.Split(',');
            string playerType = data[0];
            string naam = data[1];
            int rugNummer, rating, caps;

            //Validation
            bool rugNummerValidation = int.TryParse(data[2], out rugNummer) && rugNummer > 0 && rugNummer <= 99;
            bool ratingValidation = int.TryParse(data[data.Length - 2], out rating) && rating >= 0 && rating <= 100;
            bool capsValidation = int.TryParse(data[data.Length - 1], out caps) && caps >= 0;

            //Logs
            Dictionary<string, bool> validationLogs = new Dictionary<string, bool>()
            {
                { "rugNummerValidation", rugNummerValidation },
                { "ratingValidation", ratingValidation },
                { "capsValidation", capsValidation }
            };

            //Return
            if (!validationLogs.Values.Contains(false))
            {
                try         //dit
                {           //
                    if (playerType == "GoalKeeper")
                    {
                        List<GoalKeeperPosities> temp = new List<GoalKeeperPosities>();
                        for (int i = 3; i < data.Length - 2; i++)
                            temp.Add((GoalKeeperPosities)Enum.Parse(typeof(GoalKeeperPosities), data[i]));
                        validationLogs.Add("positionValidation", true);

                        return new GoalKeeper(naam, rugNummer, rating, caps, temp);
                    }
                    else if (playerType == "Forward")
                    {
                        List<ForwardPosities> temp = new List<ForwardPosities>();
                        for (int i = 3; i < data.Length - 2; i++)
                            temp.Add((ForwardPosities)Enum.Parse(typeof(ForwardPosities), data[i]));
                        validationLogs.Add("positionValidation", true);

                        return new Forward(naam, rugNummer, rating, caps, temp);
                    }
                    else if (playerType == "MidFielder")
                    {
                        List<MidFielderPosities> temp = new List<MidFielderPosities>();
                        for (int i = 3; i < data.Length - 2; i++)
                            temp.Add((MidFielderPosities)Enum.Parse(typeof(MidFielderPosities), data[i]));
                        validationLogs.Add("positionValidation", true);

                        return new MidFielder(naam, rugNummer, rating, caps, temp);
                    }
                    else if (playerType == "Defender")
                    {
                        List<DefenderPosities> temp = new List<DefenderPosities>();
                        for (int i = 3; i < data.Length - 2; i++)
                            temp.Add((DefenderPosities)Enum.Parse(typeof(DefenderPosities), data[i]));
                        validationLogs.Add("positionValidation", true);

                        return new Defender(naam, rugNummer, rating, caps, temp);
                    }
                    else
                    {
                        validationLogs.Add("playerTypeValidation", false);
                        validationLogs.Add("positionValidation", false);
                    }
                }       // van hier
                catch (Exception e)
                {
                    validationLogs.Add("positionValidation", false);
                    throw new SpelerinfoException("Er zitten fouten in de spelerInfo string.", validationLogs);
                }                       //tot hier
            }
            throw new SpelerinfoException("Er zitten fouten in de spelerInfo string.", validationLogs);
        }
    }
}
