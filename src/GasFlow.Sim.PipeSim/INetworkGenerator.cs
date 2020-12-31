using Energistics.DataAccess.PRODML210;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GasFlow.Sim.PipeSim.EngineFiles
{
    public interface INetworkGenerator
    {
        Task<string> Generate(ProductFlowModel model, ProductVolume volume);
    }
}
