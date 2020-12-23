using Core;

using GasFlow.Units;
using System;
using System.Collections.Generic;

namespace FlowSim
{
    public class ChokeCalkulator : ISim<Choke>
    {
        public IEnumerable<Condition> CalcModel(Choke model, IEnumerable<Condition> conditions)
        {
            var dia = model.Dia;
            var inpletPortId = model.InPlet.Id;
            var outpletPortName = model.OutPlet.Id;

            var inpletPressure = conditions.GetValue(inpletPortId, ParametrTypes.Pressure);
            var outpletPressure = conditions.GetValue(outpletPortName, ParametrTypes.Pressure);

            var q = Math.Pow(dia, 2) * outpletPressure * (inpletPressure - outpletPressure);

            yield return new Condition
            {
                PortId = inpletPortId,
                ConditionValues = new List<ConditionValue>
                {
                    new ConditionValue{Parametr=ParametrTypes.Pressure, Value=outpletPressure},
                    new ConditionValue{Parametr=ParametrTypes.VolumePerTime, Value=q}
                }
            };
        }
    }
}