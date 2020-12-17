using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Core
{
    public abstract class NetworkBase : UnitBase, INetwork, IUnit
    {
        public abstract IEnumerable<IUnit> Units { get; }

    }
}
