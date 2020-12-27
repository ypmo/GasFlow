namespace GasFlow.Optimum
{
    using Energistics.DataAccess.PRODML210;
    using GasFlow.Optimum.Dto;
    using System.Threading.Tasks;

    public interface IOptimizer
    {
        Task<FindOptimumResult> FindOptimum(FindOptimumInput input);
    }
}
