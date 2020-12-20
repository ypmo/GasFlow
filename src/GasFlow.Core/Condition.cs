using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Condition
    {
        public int PortId { get; set; }

        public IEnumerable<ConditionValue> ConditionValues { get; set; }

    }
}
