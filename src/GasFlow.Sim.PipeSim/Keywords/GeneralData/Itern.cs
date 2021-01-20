using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.GeneralData
{
    public class IternData
    {
        [Keyword("POUT=")]
        [UomPressure]
        public Meassure OutPressure { get; set; }

        [Keyword("TYPE=")]
        public IternType? Type { get; set; }
    }
}
