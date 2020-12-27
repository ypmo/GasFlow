namespace GasFlow.Optimum
{
    using Energistics.DataAccess.PRODML210;
    using GasFlow.FlowProfiler;
    using GasFlow.Optimum.Dto;
    using System;
    using System.Threading.Tasks;

    public class Optimizer : IOptimizer
    {
        private readonly IProfiler profiler;

        public Optimizer(IProfiler profiler)
        {
            this.profiler = profiler ?? throw new ArgumentNullException(nameof(profiler));
        }

        public Task<FindOptimumResult> FindOptimum(FindOptimumInput input)
        {
            throw new NotImplementedException();
        }
    }
}