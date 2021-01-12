using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.Network
{
    public class SourceData
    {
        public string Name { get; set; }
        public Meassure Pressure { get; set; }
        public Meassure Temperature { get; set; }
        public Meassure LiquidRate { get; set; }
        public Meassure GasRate { get; set; }
        public Meassure MassRate { get; set; }
        public string RemoveExistingBoundaryCondition { get; set; }

        public MeassureArray CurvePressure { get; set; }
        public MeassureArray CurveLiquidRate { get; set; }
        public MeassureArray CurveGasRate { get; set; }
        public MeassureArray CurveMassRate { get; set; }
        public MeassureArray CurveTemperature { get; set; }
        public string CurveFile { get; set; }

        public Meassure Elevation { get; set; }
        public Meassure EstPressure { get; set; }
    }
    public class SourceKeyword : IKeywordWriter
    {
        public SourceData Data { get; set; }
        SimpleP<string> Name => new("NAME=", () => Data.Name);
        MeassureP Pressure => new("PRESSURE=", new Uoms("bara", "psia"), () => Data.Pressure);
        MeassureP Temperature => new("TEMPERATURE=", new Uoms("C", "F"), () => Data.Temperature);
        MeassureP LiquidRate => new("LIQUIDRATE=", new Uoms("sm3/d", "sbbl/d"), () => Data.LiquidRate);
        MeassureP GasRate => new("GASRATE=", new Uoms("mmscm/d", "mmscf/d"), () => Data.GasRate);
        MeassureP MassRate => new("MASSRATE=", new Uoms("Kg/sec", "lb/sec"), () => Data.GasRate);
        SimpleP<string> RemoveExistingBoundaryCondition => new("REBC=", () => Data.RemoveExistingBoundaryCondition);
        MeassureArrayP CurvePressure => new("CURVEP=", new Uoms("bara", "psia"), () => Data.CurvePressure);
        MeassureArrayP CurveLiquidRate => new("CURVEL=", new Uoms("m3/d", "bbl/d"), () => Data.CurvePressure);
        MeassureArrayP CurveGasRate => new("CURVEG=", new Uoms("mmscm3/d", "mmscf/d"), () => Data.CurveGasRate);
        MeassureArrayP CurveMassRate => new("CURVEM=", new Uoms("Kg/sec", "lb/sec"), () => Data.CurveMassRate);
        MeassureArrayP CurveTemperature => new("CURVET=", new Uoms("C", "F"), () => Data.CurveTemperature );
        MeassureP Elevation => new("CURVET=", new Uoms("m", "ft"), () => Data.Elevation );
MeassureP EstPressure => new("ESTPRESSURE=", new Uoms("bara", "psia"), () => Data.EstPressure);
        public string Write(KeywordOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
