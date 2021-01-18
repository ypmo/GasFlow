using Energistics.DataAccess.PRODML210;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GasFlow.Sim.PipeSim
{
    public class NetworkGenerator : INetworkGenerator
    {
        ISingleBranchGenerator singleBranchGenerator;
        public NetworkGenerator(ISingleBranchGenerator singleBranchGenerator)
        {
            this.singleBranchGenerator = singleBranchGenerator;
        }

        public string Generate(ProductFlowModel model, ProductVolume volume)
        {

            throw new NotImplementedException();
        }
    }
}
