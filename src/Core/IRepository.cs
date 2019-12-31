using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
  public   interface IRepository<T>
    {
         T Get(string id);

    }
}
