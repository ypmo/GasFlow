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

    public interface IKeywordParametr
    {
        string ToString();
    }


    public class KeywordParametr<T> : IKeywordParametr
    {
        public KeywordParametr(string name, Func<T> value, Func<T, bool> valid = null)
        {
            Name = name;
            Value = value;
            Valid = valid;
        }

        public string Name { get; }
        public Func<T> Value { get; }
        public Func<T, bool> Valid { get; }

        public override string ToString()
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

    public class MeassureParametr : KeywordParametr<Meassure>
    {
        readonly string _unit;
        public MeassureParametr(string name, string unit, Func<Meassure> value, Func<Meassure, bool> valid = null) : base(name, value, valid)
        {
            _unit = unit;
        }

        public override string ToString()
        {
            var v = Value();
            if (v is null || Valid is not null && !Valid(v)) return string.Empty;
            var converter = new MeassureConverter.Converter();

            var v1 = converter.Convert(Value().Uom, _unit, Value().Value);

            return v1.Success ?
                $"{Name}{v1.ConvertedValue.ToString("G", CultureInfo.CreateSpecificCulture("en - En"))}" :
                throw new ArgumentException("Не удалось сконвертировать");
        }

}
