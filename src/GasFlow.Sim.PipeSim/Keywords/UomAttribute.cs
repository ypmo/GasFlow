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
    }

    /// <summary>
    /// "mm", "inch"
    /// </summary>
    public class UomLengthMini : UomAttribute
    {
        public UomLengthMini() : base("mm", "inch") { }
    }

    /// <summary>
    /// "m", "ft"
    /// </summary>
    public class UomLengthNorm : UomAttribute
    {
        public UomLengthNorm() : base("m", "ft") { }
    }

    /// <summary>
    /// "C", "F"
    /// </summary>
    public class UomTemperature : UomAttribute
    {
        public UomTemperature() : base("C", "F") { }
    }

    /// <summary>
    /// "W/m2/K", "Btu/hr/ft2/F"
    /// </summary>
    public class UomHeatTransfer : UomAttribute
    {
        public UomHeatTransfer() : base("W/m2/K", "Btu/hr/ft2/F") { }
    }

    /// <summary>
    /// "W/m/K", "Btu/hr/ft/F"
    /// </summary>
    public class UomThermalConductivity : UomAttribute
    {
        public UomThermalConductivity() : base("W/m/K", "Btu/hr/ft/F") { }
    }

    /// <summary>
    /// "bara", "psia"
    /// </summary>
    public class UomPressure : UomAttribute
    {
        public UomPressure() : base("bara", "psia") { }
    }

    /// <summary>
    /// "bar", "psi"
    /// </summary>
    public class UomDeltaPressure : UomAttribute
    {
        public UomDeltaPressure() : base("bar", "psi") { }
    }

    /// <summary>
    /// "sm3/d", "sbbl/d"
    /// </summary>
    public class UomVolumeRateMini : UomAttribute
    {
        public UomVolumeRateMini() : base("sm3/d", "sbbl/d") { }
    }
    /// <summary>
    /// "mmscm3/d", "mmscf/d"
    /// </summary>
    public class UomVolumeRateNorn : UomAttribute
    {
        public UomVolumeRateNorn() : base("mmscm3/d", "mmscf/d") { }
    }

    /// <summary>
    /// "kg/sec", "lb/sec"
    /// </summary>
    public class UomMassRate : UomAttribute
    {
        public UomMassRate() : base("kg/sec", "lb/sec") { }
    }
    /// <summary>
    /// "kW/m", "BTU/hr/ft"
    /// </summary>
    public class UomPowerPerLength : UomAttribute
    {
        public UomPowerPerLength() : base("kW/m", "BTU/hr/ft") { }
    }
}
