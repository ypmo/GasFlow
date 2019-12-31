using Core;
using Core.Componets;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlowSim
{
    public class ChokeCalkulator : ISim<Choke>
    {
        public IEnumerable<Condition> CalcModel(Choke model, IEnumerable<Condition> condition)
        {
            var dia = model.Dia;
            var inpletPortName = model.InPlet.Name;
            var outpletPortName = model.InPlet.Name;

            var inpletPressure = condition.GetValue(inpletPortName, ParametrTypes.Pressure);
            var outpletPressure = condition.GetValue(outpletPortName, ParametrTypes.Pressure );

            var q = Math.Pow(dia, 2) * outpletPressure * (inpletPressure - outpletPressure);

            yield return new Condition
            {
                PortName = inpletPortName,
                ConditionValues = new List<ConditionValue>
                {
                    new ConditionValue{Parametr=ParametrTypes.Pressure, Value=outpletPressure},
                    new ConditionValue{Parametr=ParametrTypes.VolumePerTime, Value=q}
                }
            };
        }
    }
}
