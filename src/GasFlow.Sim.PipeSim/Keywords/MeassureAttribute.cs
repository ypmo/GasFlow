using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public class MeassureAttribute : Attribute
    {
        public string SI { get; set; }
        public string ENG { get; set; }
        public string Uno { get; set; }
    }
}
