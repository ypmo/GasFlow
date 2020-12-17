using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlowSim
{
 public static   class Conditions_Extensions
    {
        public static double GetValue(this IEnumerable<Condition> conditions, string portName, ParametrTypes parametr)
        {
            var value = conditions
               .FirstOrDefault(t => t.PortName == portName)?.ConditionValues
               .FirstOrDefault(t => t.Parametr == ParametrTypes.Pressure)?.Value
               ?? throw new ArgumentNullException();

            return value;
        }
    }
}
