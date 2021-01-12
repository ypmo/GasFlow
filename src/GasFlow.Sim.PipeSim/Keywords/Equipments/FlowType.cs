using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.Equipments
{
    public enum FlowType
    {
        [Keyword("TUBING")]
        Tubing,
        [Keyword("ANNULUS")]
        Annulus,
        [Keyword("TUBANN")]
        Both
    }
}
