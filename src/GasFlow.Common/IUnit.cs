using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow
{
    public interface IUnit
    {
        IEnumerable<IPort> Ports();
    }
}
