using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Globalization;
using System.Reflection;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public interface IKeywordWriter
    {
        string Write(KeywordOptions options);
    }
}