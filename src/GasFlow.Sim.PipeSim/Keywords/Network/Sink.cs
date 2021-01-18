using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.Network
{
    public class SinkData
    {
        public string Name { get; set; }
        public Meassure Pressure { get; set; }
        public Meassure LiquidRate { get; set; }
        public Meassure GasRate { get; set; }
        public Meassure MassRate { get; set; }
        public string RemoveExistingBoundaryCondition { get; set; }


        public Meassure Elevation { get; set; }
        public Meassure EstPressure { get; set; }
    }
    public class SinkKeyword : IKeywordWriter
    {
        public SinkData Data { get; set; }
        SimpleP<string> Name => new("NAME=", Data.Name);
        MeassureP Pressure => new("PRESSURE=", new Uoms("bara", "psia"), Data.Pressure);
        MeassureP LiquidRate => new("LIQUIDRATE=", new Uoms("sm3/d", "sbbl/d"), Data.LiquidRate);
        MeassureP GasRate => new("GASRATE=", new Uoms("mmscm/d", "mmscf/d"), Data.GasRate);
        MeassureP MassRate => new("MASSRATE=", new Uoms("Kg/sec", "lb/sec"), Data.GasRate);
        SimpleP<string> RemoveExistingBoundaryCondition => new("REBC=", Data.RemoveExistingBoundaryCondition);
        MeassureP Elevation => new("CURVET=", new Uoms("m", "ft"), Data.Elevation);
        MeassureP EstPressure => new("ESTPRESSURE=", new Uoms("bara", "psia"), Data.EstPressure);
        public string Write(KeywordOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
