using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Engine
{
    public class PsEngineNumberAttribute : Attribute
    {
        public PsEngineNumberAttribute(int number)
        {
            Number = number;
        }

        public int Number { get; }
    }
}
