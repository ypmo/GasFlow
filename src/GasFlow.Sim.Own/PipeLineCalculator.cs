﻿using Core;

using GasFlow.Units;
using System;
using System.Collections.Generic;

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