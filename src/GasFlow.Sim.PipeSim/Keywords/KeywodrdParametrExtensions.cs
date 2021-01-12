using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public static class KeywodrdParametrExtensions
    {
        public static StringBuilder AppendLine(this StringBuilder stringBuilder, IKeywordParametr parametr)
        {
            var txt = parametr.ToString();
            return string.IsNullOrEmpty(txt) ? stringBuilder : stringBuilder.AppendLine(txt);
        }
    }
}
