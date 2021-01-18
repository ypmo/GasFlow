using System;
using System.Linq.Expressions;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public static class KeywordFactory
    {
        public static SimpleP<T> Create<TData, T>(TData data, Expression<Func<TData, T>> func, Func<T, bool> valid = null)
        {
            var keyword = func.Keyword();
            var value = func.Compile().Invoke(data);
            return new SimpleP<T>(keyword, value, valid);
        }

        public static MeassureP Create<TData>(TData data, Expression<Func<TData, Meassure>> func, Func<Meassure, bool> valid = null)
        {
            var keyword = func.Keyword();
            var uons = func.Uoms();
            var value = func.Compile().Invoke(data);
            return new MeassureP(keyword, uons, value, valid);
        }

        public static MeassureArrayP Create<TData>(TData data, Expression<Func<TData, MeassureArray>> func, Func<MeassureArray, bool> valid = null)
        {
            var keyword = func.Keyword();
            var uons = func.Uoms();
            var value = func.Compile().Invoke(data);
            return new MeassureArrayP(keyword, uons, value, valid);
        }
    }


}