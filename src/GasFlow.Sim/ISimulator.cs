
using GasFlow.Sim.Dto;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Energistics.DataAccess.PRODML210;
namespace GasFlow.Sim
{
    public interface ISimulator
    {
        Task<SimResult> Simulate(SimInput input, CancellationToken cancelation);
    }
}