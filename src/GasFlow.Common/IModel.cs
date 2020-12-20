using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow
{
    public interface IModel
    {
        int Id { get; }
        INetwork Network { get; }
    }
}
