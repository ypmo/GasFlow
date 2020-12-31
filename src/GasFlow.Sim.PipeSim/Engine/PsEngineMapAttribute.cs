using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Engine
{
    public class PsEngineMapAttribute : Attribute
    {

        public PsEngineMapAttribute(string map)
        {
            Map = map;
        }
        
        public string Map { get; }
    }
}
