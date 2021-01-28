using Energistics.DataAccess.PRODML210;
using System;
using System.Collections.Generic;
using System.Linq;
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
         
           var network = model.Network.FirstOrDefault() ?? throw new ArgumentNullException(nameof(model));
        foreach(var unit in     network.Unit)
            {
          
                if ( unit.Facility.Kind==Energistics.DataAccess.PRODML210.ReferenceData.ReportingFacility.pipeline )
                {
  var facility=    volume.Facility.FirstOrDefault(t => t.Unit == unit.Uid);
                   var profile= facility.ParameterSet.First(t => t.Name ==Energistics.DataAccess.PRODML210.ReferenceData.FacilityParameter.lengthclass );
                    profile.MeasureClass = Energistics.DataAccess.PRODML210.ReferenceData.MeasureClass.length;
                    foreach (var curve in profile.CurveDefinition )
                    {
                        
                    }
                }
            }
            throw new NotImplementedException();
        }
    }
}
