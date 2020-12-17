using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
 public   class Network:Unit
    {
        public List<Node> Nodes { get; set; }
        public List<IUnit> Units { get; set; }

        public override IEnumerable<Port> GetPorts()
        {
            throw new NotImplementedException();
        }
    }
}
