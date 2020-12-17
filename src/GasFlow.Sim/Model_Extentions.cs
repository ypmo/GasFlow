using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowSim
{
    public static class Model_Extentions
    {
        public static Port ResolveСonnectedPort(this Network network, Port port)
        {
            var other =
                network.Nodes.FirstOrDefault(t => t.InpletPort == port)?.OutpletPort
                ?? network.Nodes.FirstOrDefault(t => t.OutpletPort == port)?.InpletPort
                ?? throw new KeyNotFoundException();
            return other;
        }
    }
}
