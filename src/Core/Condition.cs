using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Condition
    {
        public string PortName { get; set; }

        public IEnumerable<ConditionValue> ConditionValues { get; set; }

    }
}
