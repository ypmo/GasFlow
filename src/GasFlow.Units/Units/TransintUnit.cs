﻿using GasFlow.Core;
using System.Collections.Generic;

namespace GasFlow.Units
{
    public class TransintUnit : UnitBase
    {
        public IPort InPlet { get; set; }

        public IPort OutPlet { get; set; }

        public override IEnumerable<IPort> Ports()
        {
            yield return InPlet;
            yield return OutPlet;
        }
    }
}