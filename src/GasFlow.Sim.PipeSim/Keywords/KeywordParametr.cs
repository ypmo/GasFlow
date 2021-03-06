﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public class SimpleP<T>
    {
        public SimpleP(string name, T value)
        {
            Name = name;
            Value = value;
        }

        public string Name { get; }
        public T Value { get; }

        public string Write()
        {
            if (Value is null) return string.Empty;

            if (typeof(T).IsEnum)
            {
                var attr = Value.GetEnumAttribute<T, KeywordAttribute>();
                return (attr != null) ? $"{Name}{attr.Keyword}" : $"{Name}{Value}";
            }

            return Value switch
            {
                double d => $"{Name}{d.ToString("G", CultureInfo.CreateSpecificCulture("en-En"))}",
                string s => string.IsNullOrEmpty(s) ? string.Empty : $"{Name}'{s}'",
                IEnumerable<string> ms => $"{Name} {string.Join(" ", ms)}",
                _ => throw new NotImplementedException()
            };
        }
    }

    public class MeassureP
    {

        public MeassureP(string name, Uoms uoms, Meassure value)
        {
            Name = name;
            Value = value;
            Uoms = uoms;
        }
        public string Name { get; }
        public Uoms Uoms { get; set; }
        public Meassure Value { get; }

        public string Write(UomSystem uomSystem)
        {


            if (Value is null) return string.Empty;
            var converter = new MeassureConverter.Converter();
            var uom = Uoms.Uom(uomSystem);
            var v1 = converter.Convert(Value.Uom, uom, Value.Value);

            return v1.Success ?
                $"{Name}{v1.ConvertedValue.ToString("G", CultureInfo.CreateSpecificCulture("en - En"))}" :
                throw new ArgumentException("Не удалось сконвертировать");
        }
    }

    public class MeassureArrayP
    {
        readonly Uoms uoms;
        public MeassureArrayP(string name, Uoms uoms, MeassureArray value)
        {
            Name = name;
            Value = value;
            this.uoms = uoms;
        }
        public string Name { get; }
        public MeassureArray Value { get; }

        public string Write(UomSystem uomSystem)
        {


            if (Value is null) return string.Empty;
            var converter = new MeassureConverter.Converter();
            var uom = uoms.Uom(uomSystem);
            var v1 = Value.Value.Select(m => converter.Convert(Value.Uom, uom, m));

            return v1.All(i => i.Success) ?
                $"{Name}&#123{string.Join(", ", v1.Select(i => i.ConvertedValue.ToString("G", CultureInfo.CreateSpecificCulture("en - En"))))}&#125" :
                throw new ArgumentException("Не удалось сконвертировать");
        }
    }
}
