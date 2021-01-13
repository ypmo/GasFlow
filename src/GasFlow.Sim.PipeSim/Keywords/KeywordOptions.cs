using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public class KeywordOptions
    {
        public UomSystem UomSystem { get; set; }
    }

    public enum UomSystem
    {
        Si,
        Eng
    }
}
