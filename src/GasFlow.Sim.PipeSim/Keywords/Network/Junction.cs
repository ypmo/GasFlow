using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.Network
{
    public class JunctionData
    {
        [Keyword("NAME=")]
        public string Name { get; set; }

        /// <summary>
        /// Estimate of pressure to be used as a starting point for the network solution (bara or psia)
        /// </summary>
        [Keyword("ESTPRESSURE=")]
        [UomPressure]
        public Meassure Pressure { get; set; }

        /// <summary>
        /// Estimate of fluid temperature to be used as a starting point for the network solution (F or C)
        /// </summary>
        [Keyword("ESTTEMPERATURE=")]
        [UomTemperature]
        public Meassure Temperature { get; set; }

        /// <summary>
        /// Absolute elevation of the junction (ft or m). If supplied, this will be used as a datum for plotting branch elevations.
        /// </summary>
        [Keyword("ELEVATION=")]
        [UomLengthNorm]
        public Meassure Elevation { get; set; }

    }
}
