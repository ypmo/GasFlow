using Core;
using GasFlow.Units;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowSim
{
    public class CompletionCalculator : ISim<WellboreComplition>
    {
        public IEnumerable<Condition> CalcModel(WellboreComplition model, IEnumerable<Condition> conditions)
        {
            var downholePortId = model.OutPlet.Id;
            var reservoirPortId = model.InPlet.Id;
            var Pres = conditions
                .FirstOrDefault(t => t.PortId == reservoirPortId)?.ConditionValues
                .FirstOrDefault(t => t.Parametr == ParametrTypes.Pressure)?.Value
                ?? throw new ArgumentNullException();

            var Pdh = conditions
                .FirstOrDefault(t => t.PortId == downholePortId)?.ConditionValues
                .FirstOrDefault(t => t.Parametr == ParametrTypes.Pressure)?.Value
                ?? throw new ArgumentNullException();

            var a = model.kA;
            var b = model.kB;
            var q = (-a + Math.Sqrt(a * a + 4 * b * (Pres * Pres - Pdh * Pdh))) / (2 * b);

            yield return new Condition
            {
                PortId = downholePortId,
                ConditionValues = new List<ConditionValue>
                {
                    new ConditionValue{Parametr=ParametrTypes.VolumePerTime, Value=q}
                }
            };
        }
    }
}