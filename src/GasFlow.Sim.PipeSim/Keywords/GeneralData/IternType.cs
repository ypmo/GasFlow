using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GasFlow.Sim.PipeSim.Keywords.GeneralData
{
    public enum IternType
    {
        [XmlEnum("PRESSURE")]
        Pressure,
        [XmlEnum("GFLOW")]
        GasFlowRate,
        [XmlEnum("LFLOW")]
        LiquidFlowRate,
        [XmlEnum("MFLOW")]
        MassFlowRate
    }
}
