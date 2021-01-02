using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.Equipments
{
  public   enum SubCriticalFlowCorrelation
    {
        [Keyword("ASHFORD")]
        AshfordAndPierce,
        [Keyword("MECHANISTIC")]
        Mechanistic,
        [Keyword("API14B")]
        SpecialMechanistic,
    }
}
