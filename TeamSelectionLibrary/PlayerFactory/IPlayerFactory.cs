using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectionLibrary
{
    public interface IPlayerFactory
    {
        public Speler MaakSpeler(string spelerInfo);
    }
}
