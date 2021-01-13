using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public static class KeywodrdParametrExtensions
    {
        public static StringBuilder AppendLine<T>(this StringBuilder stringBuilder, SimpleP<T> parametr)
        {
            var txt = parametr.Write();
            return string.IsNullOrEmpty(txt) ? stringBuilder : stringBuilder.AppendLine(txt);
        }

        public static StringBuilder AppendLine(this StringBuilder stringBuilder, MeassureP parametr, UomSystem uomSystem  )
        {
            var txt = parametr.Write(uomSystem);
            return string.IsNullOrEmpty(txt) ? stringBuilder : stringBuilder.AppendLine(txt);
        }
    }
}
