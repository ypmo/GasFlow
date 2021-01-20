using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.GeneralData
{
    public class InletData
    {
        [Keyword("TEMPERATURE=")]
        [UomTemperature]
        public Meassure Temperature { get; set; }

        [Keyword("PRESSURE=")]
        [UomPressure]
        public Meassure Pressure { get; set; }

        [Keyword("ENTHALPY=")]
        [UomEnergyPerVolum]
        public Meassure Enthalpy { get; set; }

        [Keyword("QUALITY=")]
        [Range(0, 1)]
        public double? Quality { get; set; }
    }
}
