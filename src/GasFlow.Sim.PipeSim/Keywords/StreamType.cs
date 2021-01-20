using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public enum StreamType
    {
        [XmlEnum("GAS")]
        Gas,
        [XmlEnum("LIQUID")]
        Liquid,
        [XmlEnum("WATER")]
        Water
    }
}
