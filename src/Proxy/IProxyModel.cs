using Core;
using System;

namespace Proxy
{
    public interface IProxyModel
    {
        ProductFlow GetFlow(Port port, Condition condition);
        Model Model { get; }
    }
}
