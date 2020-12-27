using Core;

using GasFlow.Units;
using System.Collections.Generic;

namespace FlowSim
{
    public class CompressorCalculator 
    {
        public IEnumerable<Condition> CalcModel(Compressor model, IEnumerable<Condition> condition)
        {
            var compressionRation = model.СompressionRatio;
            var inpletPortId = model.InPlet.Id;
            var outpletPortId = model.InPlet.Id ;

            var inpletPressure = condition.GetValue(inpletPortId, ParametrTypes.Pressure);
            var inpletRatio = condition.GetValue(inpletPortId, ParametrTypes.VolumePerTime);

            var outPletPRessure = compressionRation * inpletPressure;

            yield return new Condition
            {
                PortId = outpletPortId,
                ConditionValues = new List<ConditionValue>
                {
                    new ConditionValue{Parametr=ParametrTypes.Pressure, Value=outPletPRessure},
                    new ConditionValue{Parametr=ParametrTypes.VolumePerTime, Value=inpletRatio}
                }
            };
        }
    }
}