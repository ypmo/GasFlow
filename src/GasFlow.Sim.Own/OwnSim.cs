using Energistics.DataAccess.PRODML210;
using GasFlow.Sim.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GasFlow.Sim.Own
{
    public class OwnSim : ISimulator
    {
        public Task<SimResult> Simulate(SimInput input, CancellationToken cancelation)
        {
            throw new NotImplementedException();
        }
    }
}
