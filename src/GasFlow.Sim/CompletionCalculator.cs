using Core;
using Core.Componets;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace FlowSim
{
    public class CompletionCalculator : ISim<WellboreComplition>
    {

        public IEnumerable<Condition> CalcModel(WellboreComplition model, IEnumerable<Condition> conditions)
        {
            var downholePortName = model.Downhole.Name;
            var reservoirPortName = model.Reservoir.Name;
            var Pres = conditions
                .FirstOrDefault(t => t.PortName == reservoirPortName)?.ConditionValues
                .FirstOrDefault(t => t.Parametr == ParametrTypes.Pressure)?.Value
                ?? throw new ArgumentNullException();

            var Pdh = conditions
                .FirstOrDefault(t => t.PortName == downholePortName)?.ConditionValues
                .FirstOrDefault(t => t.Parametr == ParametrTypes.Pressure)?.Value
                ?? throw new ArgumentNullException();

            var a = model.kA;
            var b = model.kB;
            var q = (-a + Math.Sqrt(a * a + 4 * b * (Pres * Pres - Pdh * Pdh))) / (2 * b);

            yield return new Condition
            {
                PortName = downholePortName,
                ConditionValues = new List<ConditionValue>
                {
                    new ConditionValue{Parametr=ParametrTypes.VolumePerTime, Value=q}
                }
            };
        }
    }
}
