using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.Network
{
  public enum WellOperation
    {
        /// <summary>
        /// Shut in any well that is operating in its unstable region. This is the default.
        /// </summary>
        [Keyword("SHUT")]
        Shut,

        /// <summary>
        /// allow unstable wells to remain in operation.
        /// </summary>
        [Keyword("FLOW")]
        Flow
    }
}
