using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Condition
    {
        public DateTime DateTime { get; set; }
        public string PortName { get; set; }

        public IEnumerable<ConditionValue> ConditionValues { get; set; }

    }
}
