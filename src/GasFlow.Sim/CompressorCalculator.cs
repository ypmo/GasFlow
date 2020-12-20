using Core;

using GasFlow.Units;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlowSim
{
    public class CompressorCalculator : ISim<Compressor>
    {
        public IEnumerable<Condition> CalcModel(Compressor model, IEnumerable<Condition> condition)
        {
            var compressionRation = model.СompressionRatio;
            var inpletPortName = model.InPlet.Name;
            var outpletPortName = model.InPlet.Name;

            var inpletPressure = condition.GetValue(inpletPortName, ParametrTypes.Pressure);
            var inpletRatio = condition.GetValue(inpletPortName, ParametrTypes.VolumePerTime);

            var outPletPRessure = compressionRation * inpletPressure;

            yield return new Condition
            {
                PortId = outpletPortName,
                ConditionValues = new List<ConditionValue>
                {
                    new ConditionValue{Parametr=ParametrTypes.Pressure, Value=outPletPRessure},
                    new ConditionValue{Parametr=ParametrTypes.VolumePerTime, Value=inpletRatio}
                }
            };
        }
    }
}
