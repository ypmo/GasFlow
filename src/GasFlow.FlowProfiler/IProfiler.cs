using GasFlow.FlowProfiler.Dto;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GasFlow.FlowProfiler
{
    public interface IProfiler
    {
        Task<GetProfileResult> GetProfile(GetProfileInput input, CancellationToken cancelation);
    }
}
