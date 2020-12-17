using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
   public  class Port:IEquatable<Port>
    {

        public string Name { get; set; }
        public FlowDirection  Direction { get; set; }

        public bool Equals(Port other)
        {
            if (ReferenceEquals(this, other)) return true;

            if (other == default) return false;

            return this.Name == other.Name;
        }
    }
}
