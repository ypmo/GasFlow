using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public class Meassure
    {
        public double Value { get; set; }
        public string Uom { get; set; }
    }
    public class MeassureArray
    {
        public double[] Value { get; set; }
        public string Uom { get; set; }
    }

  
}
