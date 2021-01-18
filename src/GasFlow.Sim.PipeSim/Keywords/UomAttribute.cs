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

        //Extensions CTORs
        private void setUoms<TS, TE>(TS si, TE eng)
        {
            SI = si.GetEnumAttribute<TS, XmlEnumAttribute>()?.Name ?? si.ToString();
            ENG = eng.GetEnumAttribute<TE, XmlEnumAttribute>()?.Name ?? si.ToString();
        }

        public UomAttribute(SiLength si, EngLength eng) => setUoms(si, eng);
        public UomAttribute(SiTemp si, EngTemp eng) => setUoms(si, eng);
        public UomAttribute(SiHeatTransfer si, EngHeatTransfer eng) => setUoms(si, eng);
        public UomAttribute(SiThermalConductivity si, EngThermalConductivity eng) => setUoms(si, eng);
        public UomAttribute(SiPressure si, EngPressure eng) => setUoms(si, eng);

    }



    public enum SiLength
    {
        [XmlEnum("mm")]
        mm,
        [XmlEnum("m")]
        m
    }

    public enum EngLength
    {
        [XmlEnum("inch")]
        inch,
        [XmlEnum("ft")]
        ft
    }

    public enum SiTemp
    {
        [XmlEnum("C")]
        C
    }

    public enum EngTemp
    {
        [XmlEnum("F")]
        F
    }

    public enum SiHeatTransfer
    {
        [XmlEnum("W/m2/K")]
        Wm2K
    }

    public enum EngHeatTransfer
    {
        [XmlEnum("Btu/hr/ft2/F")]
        BtuHrFt2F
    }


    public enum SiThermalConductivity
    {
        [XmlEnum("W/m/K")]
        WmK
    }

    public enum EngThermalConductivity
    {
        [XmlEnum("Btu/hr/ft/F")]
        BtuHrFtF
    }

    public enum SiPressure
    {
        [XmlEnum("bara")]
        bara,
        [XmlEnum("bar")]
        bar
    }

    public enum EngPressure
    {
        [XmlEnum("psia")]
        psia,
        [XmlEnum("psi")]
        psi
    }
}
