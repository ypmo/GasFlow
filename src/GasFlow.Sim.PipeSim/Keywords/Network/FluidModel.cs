using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GasFlow.Sim.PipeSim.Keywords.Network
{
    public enum FluidModel
    {
        /// <summary>
        /// Fluid type is set to black oil
        /// </summary>
        [XmlEnum("BLACKOIL")]
        BlackOil,

        /// <summary>
        /// Fluid type is set to compositional
        /// </summary>
        [XmlEnum("COMPOSITION")]
        Composition,

        /// <summary>
        /// fluid type is set to steam
        /// </summary>
        [XmlEnum("STEAM")]
        Steam
    }
}
