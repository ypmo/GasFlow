using Core;
using System.Collections.Generic;

namespace FlowSim
{
    public interface ISim<TModel>
    {
        IEnumerable<Condition> CalcModel(TModel model, IEnumerable<Condition> condition);
    }
}