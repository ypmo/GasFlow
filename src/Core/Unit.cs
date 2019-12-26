using System;
using System.Collections.Generic;

namespace Core
{
    public abstract class Unit : IUnit
    {
        public abstract  IEnumerable<Port> GetPorts();
    }
}
