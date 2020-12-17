using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Componets
{
    public class PipeLine : Unit
    {
        public double Din { get; set; }
        public double Length { get; set; }

        public Port InPlet { get; set; }
        public Port OutPlet { get; set; }
        public override IEnumerable<Port> GetPorts()
        {
            yield return InPlet;
            yield return OutPlet;
        }
    }
}
