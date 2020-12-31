using GasFlow.Sim.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;
namespace GasFlow.Sim
{
    public class Simulator : ISimulator
    {
        public Task<SimResult> Simulate(SimInput input, CancellationToken cancellation)
        {
            if (cancellation.IsCancellationRequested) return Task.FromCanceled<SimResult>(cancellation);

            if (input is null) return Task.FromException<SimResult>(new ArgumentNullException(nameof(input)));
            if (input.FlowModel is null) return Task.FromException<SimResult>(new ArgumentNullException(nameof(input.FlowModel)));
            if (input.FlowModel.Network is null || !input.FlowModel.Network.Any()) return Task.FromException<SimResult>(new ArgumentNullException(nameof(input.FlowModel.Network)));

            var network = input.FlowModel.Network.FirstOrDefault();

            throw new NotImplementedException();
        }
    }
}
