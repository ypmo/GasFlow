using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public enum YesNo
    {
        [XmlEnum("YES")]
        Yes,
        [XmlEnum("NO")]
        No
    }
}
