using System;
using System.Threading;
using System.Threading.Tasks;
using Energistics.DataAccess.PRODML210;

namespace GasFlow.Tuning.Dto
{
    public class TuneInput
    {
        public ProductFlowModel FlowModel { get; set; }
        public ProductVolume TargetVolume { get; set; }
        public ProductVolume VariableVolume { get; set; }
    }
}