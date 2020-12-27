using System.Collections.Generic;

namespace GasFlow
{
    public interface INetwork : IUnit
    {
        IEnumerable<IUnit> Units { get; }
    }
}