using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public class KeywordOptions
    {
        public Unit Unit { get; set; }
    }

    public enum Unit
    {
        Si,
        Eng
    }
}
