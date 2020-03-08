using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectionLibrary
{
    public interface IPlayerFactory
    {
        Speler MaakSpeler(string spelerInfo);
    }
}
