using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlowSim
{
    public interface ISim<TModel>
    {
       IEnumerable<Condition> CalcModel(TModel model, IEnumerable<Condition> condition);
    }
}
