using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public class UomAttribute : Attribute
    {
        protected UomAttribute() { }

        public UomAttribute(string uno)
        {
            Uno = uno;
        }
        public UomAttribute(string si, string eng)
        {
            SI = si;
            ENG = eng;
        }

        public UomAttribute(Uoms uoms)
        {
            SI = uoms.SI;
            ENG = uoms.ENG;
            Uno = uoms.Uno;
        }

        public string SI { get; set; }
        public string ENG { get; set; }
        public string Uno { get; set; }
    }

    public static class  UomAttributeExtensions
    {
        public static Uoms Uoms (this UomAttribute attribute)
        {
            return new Uoms() { SI = attribute.SI, ENG = attribute.ENG, Uno = attribute.Uno };
        }
    }

    public class UomLengthAttribute : UomAttribute
    {
        public UomLengthAttribute(SiLength si, EngLength eng) : base()
        {
            SI = si.GetEnumAttribute<SiLength, XmlEnumAttribute>()?.Name ?? si.ToString();
            ENG = eng.GetEnumAttribute<EngLength, XmlEnumAttribute>()?.Name ?? si.ToString();
        }

    }
}
