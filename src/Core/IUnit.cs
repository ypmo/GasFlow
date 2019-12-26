using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public interface IUnit
    {
        IEnumerable<Port> GetPorts();
    }
}
