using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GasFlow.Sim.PipeSim.Keywords.Network
{
  public enum Algorithm
    {
        /// <summary>
        ///  default
        /// </summary>
        [XmlEnum("WEGSTEIN")]
        WEGSTEIN,
        [XmlEnum("JACOBIAN")]
        JACOBIAN
    }
}
