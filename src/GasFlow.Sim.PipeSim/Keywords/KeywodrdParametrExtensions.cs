using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public static class KeywodrdParametrExtensions
    {
        public static StringBuilder AppendLine<T>(this StringBuilder stringBuilder, KeywodrdParametr<T> parametr) => string.IsNullOrEmpty(parametr.Text) ? stringBuilder : stringBuilder.AppendLine(parametr.Text);
    }
}
