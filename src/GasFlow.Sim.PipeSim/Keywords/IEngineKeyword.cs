using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Globalization;
using System.Reflection;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public interface IEngineKeyword
    {
        string WriteText(KeywordOptions options);
    }

    public interface IKeywordParametr
    {
        string Text { get; }
    }


    public class KeywodrdParametr<T> : IKeywordParametr
    {
        public KeywodrdParametr(string name, Func<T> value, Func<T, bool> valid = null)
        {
            Name = name;
            Value = value;
            Valid = valid;
        }

        public string Name { get; }
        public Func<T> Value { get; }
        public Func<T, bool> Valid { get; }

        public virtual string Text
        {
            get
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
                    Meassure meassure => throw new NotImplementedException(),
                    _ => throw new NotImplementedException()
                };
            }
        }
    }

    public class MeassureParametr : KeywodrdParametr<Meassure>
    {
        public MeassureParametr(string name, string si, string eng, Func<Meassure> value, Func<Meassure, bool> valid = null) : base(name, value, valid)
        {
            SiUom = si;
            EngUom = eng;
        }

        public string SiUom { get; set; }
        public string EngUom { get; set; }

        public override string Text
        {
            get
            {
                var v = Value();
                if (v is null || Valid is not null && !Valid(v)) return string.Empty;

                return base.Text;
            }
        }
    }

}
