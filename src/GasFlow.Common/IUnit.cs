using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow
{
    public interface IUnit
    {
        int Id { get; }
        IEnumerable<IPort> Ports();
    }
}
