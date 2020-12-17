using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Componets
{
    public class Compressor : Unit
    {
        public double СompressionRatio { get; set; }

        public Port InPlet { get; set; }
        public Port OutPlet { get; set; }
        public override IEnumerable<Port> GetPorts()
        {
            yield return InPlet;
            yield return OutPlet;
        }
    }
}
