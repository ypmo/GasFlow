using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public abstract class Repository<TEntity>
    {
        public abstract TEntity Get(string id);
      }
}
