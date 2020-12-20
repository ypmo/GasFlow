using System.Collections.Generic;

namespace Core
{
    public class Condition
    {
        public int PortId { get; set; }

        public IEnumerable<ConditionValue> ConditionValues { get; set; }
    }
}