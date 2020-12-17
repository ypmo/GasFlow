using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Core
{
    public class PortBase : IPort
    {
        public string Name { get; set; }
        public FlowDirection Direction { get; set; }
    }
}
