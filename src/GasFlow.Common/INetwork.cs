using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow
{
    public interface INetwork : IUnit
    {
        int Id { get; }
        IEnumerable<IUnit> Units { get; }
    }
}
