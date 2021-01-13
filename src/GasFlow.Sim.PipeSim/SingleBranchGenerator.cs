using Energistics.DataAccess.PRODML210;
using Energistics.DataAccess.PRODML210.ReferenceData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GasFlow.Sim.PipeSim
{
    public class SingleBranchGenerator : ISingleBranchGenerator
    {
        public string Generate(ProductFlowModel model, ProductVolume volume)
        {
            var units = model.Network.First().Unit;
            foreach(var unit in units )
            {
                var facilityKind = unit.Facility.Kind;
                //var t = facilityKind switch
                //{
                //    _=>throw new NotImplementedException()
                //};
            }
            throw new NotImplementedException();
        }
    }
}
