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


    public class SimpleP<T>
    {
        public SimpleP(string name, Func<T> value, Func<T, bool> valid = null)
        {
            Name = name;
            Value = value;
            Valid = valid;
        }

        public string Name { get; }
        public Func<T> Value { get; }
        public Func<T, bool> Valid { get; }

        public string Write()
        {
            var v = Value();
            if (v is null || Valid is not null && !Valid(v)) return string.Empty;

            if (typeof(T).IsEnum)
            {
                var attr = v.GetEnumAttribute<T, KeywordAttribute>();
                return (attr != null) ? $"{Name}{attr.Keyword}" : $"{Name}{v}";
            }

            return v switch
            {
                double d => $"{Name}{d.ToString("G", CultureInfo.CreateSpecificCulture("en-En"))}",
                string s => string.IsNullOrEmpty(s) ? string.Empty : $"{Name}'{s}'",
                _ => throw new NotImplementedException()
            };
        }
    }

    public class MeassureP
    {
        readonly Uoms uoms;
        public MeassureP(string name, Uoms uoms, Func<Meassure> value, Func<Meassure, bool> valid = null)
        {
            Name = name;
            Value = value;
            Valid = valid;
            this.uoms = uoms;
        }
        public string Name { get; }
        public Func<Meassure> Value { get; }
        public Func<Meassure, bool> Valid { get; }

        public string Write(UomSystem uomSystem)
        {

            var v = Value();
            if (v is null || Valid is not null && !Valid(v)) return string.Empty;
            var converter = new MeassureConverter.Converter();
            var uom = uoms.Uom(uomSystem);
            var v1 = converter.Convert(Value().Uom, uom, Value().Value);

            return v1.Success ?
                $"{Name}{v1.ConvertedValue.ToString("G", CultureInfo.CreateSpecificCulture("en - En"))}" :
                throw new ArgumentException("Не удалось сконвертировать");
        }
    }
    public class MeassureArrayP
    {
        readonly Uoms uoms;
        public MeassureArrayP(string name, Uoms uoms, Func<MeassureArray> value, Func<MeassureArray, bool> valid = null)
        {
            Name = name;
            Value = value;
            Valid = valid;
            this.uoms = uoms;
        }
        public string Name { get; }
        public Func<MeassureArray> Value { get; }
        public Func<MeassureArray, bool> Valid { get; }

        public string Write(UomSystem uomSystem)
        {

            var v = Value();
            if (v is null || Valid is not null && !Valid(v)) return string.Empty;
            var converter = new MeassureConverter.Converter();
            var uom = uoms.Uom(uomSystem);
            var v1 = Value().Value.Select(m=> converter.Convert(Value().Uom, uom, m));

            return v1.All(i=>i.Success) ?
                $"{Name}&#123{string.Join(", ", v1.Select(i=> i.ConvertedValue.ToString("G", CultureInfo.CreateSpecificCulture("en - En"))))}&#125" :
                throw new ArgumentException("Не удалось сконвертировать");
        }
    }
}