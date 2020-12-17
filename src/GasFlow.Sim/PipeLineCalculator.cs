using Core;
using Core.Componets;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlowSim
{
    public class PipeLineCalculator : ISim<PipeLine>
    {
        public IEnumerable<Condition> CalcModel(PipeLine model, IEnumerable<Condition> condition)
        {
            throw new NotImplementedException();
        }
    }
}
