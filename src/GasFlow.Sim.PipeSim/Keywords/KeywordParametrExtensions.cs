using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public static class KeywordParametrExtensions
    {
        public static StringBuilder AppendLine<T>(this StringBuilder stringBuilder, SimpleP<T> parametr)
        {
            var txt = parametr.Write();
            return string.IsNullOrEmpty(txt) ? stringBuilder : stringBuilder.AppendLine(txt);
        }

        public static StringBuilder AppendLine(this StringBuilder stringBuilder, MeassureP parametr, UomSystem uomSystem)
        {
            var txt = parametr.Write(uomSystem);
            return string.IsNullOrEmpty(txt) ? stringBuilder : stringBuilder.AppendLine(txt);
        }

        public static StringBuilder AppendLine(this StringBuilder stringBuilder, MeassureArrayP parametr, UomSystem uomSystem)
        {
            var txt = parametr.Write(uomSystem);
            return string.IsNullOrEmpty(txt) ? stringBuilder : stringBuilder.AppendLine(txt);
        }

        public static StringBuilder AppendLine<TData, TArg>(this StringBuilder stringBuilder, TData data, Expression<Func<TData, TArg>> exp)
        {
            var parametr = KeywordFactory.Create<TData, TArg>(data, exp);
            return stringBuilder.AppendLine(parametr);
        }

        public static StringBuilder AppendLine<TData>(this StringBuilder stringBuilder, TData data, Expression<Func<TData, Meassure>> exp, UomSystem uomSystem)
        {
            var parametr = KeywordFactory.Create<TData>(data, exp);
            return stringBuilder.AppendLine(parametr, uomSystem);
        }

        public static StringBuilder AppendLine<TData>(this StringBuilder stringBuilder, TData data, Expression<Func<TData, MeassureArray>> exp, UomSystem uomSystem)
        {
            var parametr = KeywordFactory.Create<TData>(data, exp);
            return stringBuilder.AppendLine(parametr, uomSystem);
        }
    }
}
