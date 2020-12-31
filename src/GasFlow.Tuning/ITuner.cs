using GasFlow.Tuning.Dto;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace GasFlow.Tuning
{
    public interface ITuner
    {
        Task<TuneResult> Tune(TuneInput input, CancellationToken cancelation);
    }
}
