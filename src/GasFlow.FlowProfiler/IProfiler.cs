using GasFlow.FlowProfiler.Dto;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GasFlow.FlowProfiler
{
    public interface IProfiler
    {
        Task<IGetProfileResult> GetProfile(IGetProfileInput input, CancellationToken cancelation);
    }
}
