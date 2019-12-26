using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Componets
{
    public class WellboreComplition : Unit
    {

        public double kA { get; set; }
        public double kB { get; set; }

        public Port Reservoir { get; set; }
        public Port Downhole { get; set; }

        public override IEnumerable<Port> GetPorts()
        {
            yield return Reservoir;
            yield return Downhole;
        }
    }
}
