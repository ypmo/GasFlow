using Energistics.DataAccess.PRODML200;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GasFlow.Sim.Own
{
    public class OwnSim : ISim
    {
        public Task<ProductVolume> CalcModel(ProductFlowModel model, ProductVolume volume)
        {
            
            throw new NotImplementedException();
        }
    }
}
