using System.Collections.Generic;

namespace GasFlow
{
    public interface IUnit
    {
        int Id { get; }

        IEnumerable<IPort> Ports();
    }
}