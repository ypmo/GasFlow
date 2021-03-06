﻿using System.Collections.Generic;

namespace GasFlow.Core
{
    public abstract class NetworkBase : UnitBase, INetwork, IUnit
    {
        public abstract IEnumerable<IUnit> Units { get; }
    }
}