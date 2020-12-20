using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Core
{
    public class ModelBase : IModel
    {
        public INetwork Network { get; }
    }
}
