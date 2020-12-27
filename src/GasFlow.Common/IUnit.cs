using System.Collections.Generic;

namespace GasFlow
{
    public interface IUnit : IEntity
    {
        IEnumerable<IPort> Ports();
    }
}