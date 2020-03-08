using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectionLibrary
{
    interface IPlayerFactory
    {
        Speler MaakSpeler(string spelerInfo);
    }
}
