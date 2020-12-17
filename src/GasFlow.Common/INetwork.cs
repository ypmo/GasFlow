using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow
{
    public interface INetwork : IUnit
    {
        IEnumerable<IUnit> Units { get; }
    }
}
