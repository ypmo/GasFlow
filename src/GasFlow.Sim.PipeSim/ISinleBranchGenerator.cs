using Energistics.DataAccess.PRODML210;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GasFlow.Sim.PipeSim
{
    public interface ISingleBranchGenerator
    {
        string Generate(ProductFlowModel model, ProductVolume volume);
    }

}
