using System;
using System.Collections.Generic;

namespace OpgaveTeamSelection
{
    public class SpelerinfoException : Exception
    {
        public Dictionary<string, bool> Logs { get; set; }
        public SpelerinfoException(string message, Dictionary<string,bool> log) : base(message) => Logs = log;
    }
}
