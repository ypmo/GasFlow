using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using GasFlow.Tuning.Dto;

namespace GasFlow.Tuning
{
    public class Tuner : ITuner
    {
        public Task<TuneResult> Tune(TuneInput input, CancellationToken cancellation)
        {
            if (cancellation.IsCancellationRequested) return Task.FromCanceled<TuneResult>(cancellation);

            throw new NotImplementedException();
        }
    }
}
