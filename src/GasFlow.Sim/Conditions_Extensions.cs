using Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowSim
{
    public static class Conditions_Extensions
    {
        public static double GetValue(this IEnumerable<Condition> conditions, int portId, ParametrTypes parametr)
        {
            var value = conditions
               .FirstOrDefault(t => t.PortId == portId)?.ConditionValues
               .FirstOrDefault(t => t.Parametr == ParametrTypes.Pressure)?.Value
               ?? throw new ArgumentNullException();

            return value;
        }
    }
}