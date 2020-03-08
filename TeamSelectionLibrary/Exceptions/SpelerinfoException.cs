using System;
using System.Collections.Generic;

namespace TeamSelectionLibrary
{
    public class SpelerinfoException : Exception
    {
        public Dictionary<string, bool> Logs { get; set; }
        public SpelerinfoException(string message, Dictionary<string,bool> log) : base(message) => Logs = log;
    }
}
