using System;
using System.Collections.Generic;
using System.Text;

namespace TeamSelectionLibrary
{
    public interface IStrategie : IComparer<Speler>
    {
        IAanvoerderVoorwaarde AanvoerderVoorwaarde { get; set; }

    }
}
