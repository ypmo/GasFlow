using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Core
{
    public abstract class UnitBase : IUnit
    {
        public abstract IEnumerable<IPort> Ports();
    }
}
