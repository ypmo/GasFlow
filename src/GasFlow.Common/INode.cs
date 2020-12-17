using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow
{
    public interface INode
    {
        IPort InpletPort { get; }
        IPort OutpletPort { get;}
    }
}
