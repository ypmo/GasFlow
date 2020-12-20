using System.Collections.Generic;

namespace GasFlow.Core
{
    public abstract class UnitBase : IUnit
    {
        public int Id { get; }
        public abstract IEnumerable<IPort> Ports();
    }
}