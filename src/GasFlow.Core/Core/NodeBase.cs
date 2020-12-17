using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Core
{
    public abstract  class NodeBase:INode
    {
       public abstract  IPort InpletPort { get; }
        public abstract IPort OutpletPort { get; }
    }
}
