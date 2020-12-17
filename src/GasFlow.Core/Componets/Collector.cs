using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Componets
{
    public class Collector : Unit
    {
        private List<Port> Ports { get; set; }
        public override IEnumerable<Port> GetPorts() => Ports;
    }
}
