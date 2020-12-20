using System.Collections.Generic;

namespace GasFlow
{
    public interface INetwork : IUnit
    {
        int Id { get; }
        IEnumerable<IUnit> Units { get; }
    }
}