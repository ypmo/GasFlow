using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.GeneralData
{
    public class RateData
    {
        [Keyword("LIQ=")]
        [UomVolumeRateMini]
        public Meassure Liquid { get; set; }

        [Keyword("GAS=")]
        [UomVolumeRateNorn]
        public Meassure Gas { get; set; }

        [Keyword("MASS=")]
        [UomMassRate]
        public Meassure Mass { get; set; }

        [Keyword("MULTIPLIER=")]
        public double? Multiplier { get; set; }

        [Keyword("ADDLIQ=")]
        [UomVolumeRateMini]
        public Meassure AddLiquid { get; set; }

        [Keyword("ADDGAS=")]
        [UomVolumeRateNorn]
        public Meassure AddGas { get; set; }

        [Keyword("ADDMASS=")]
        [UomMassRate]
        public Meassure AddMass { get; set; }
    }


}
