using System;
using System.Collections.Generic;
using System.Text;
using Core;

namespace Proxy
{
    public class ProxyModel 
    {
        public ProxyModel(Model model)
        {
            Model = model;
        }

        public Model Model { get; }

        public ProductFlow GetFlow(Port port, Condition condition)
        {
            throw new NotImplementedException();
        }



    }
}
