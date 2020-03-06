using System;
using System.Collections.Generic;

namespace OpgaveTeamSelection
{
    public class SpelerinfoException : Exception
    {
        public List<bool> Logs { get; set; }
        public SpelerinfoException(string message, List<bool> log) : base(message) => Logs = log;
    }
}
