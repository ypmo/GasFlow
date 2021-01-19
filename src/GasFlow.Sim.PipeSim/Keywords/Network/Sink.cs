using System;

namespace GasFlow.Sim.PipeSim.Keywords.Network
{
    public class SinkData
    {
        [Keyword("NAME=")]
        public string Name { get; set; }

        [Keyword("PRESSURE=")]
        [UomPressure]
        public Meassure Pressure { get; set; }

        [Keyword("LIQUIDRATE=")]
        [UomVolumeRateMini]
        public Meassure LiquidRate { get; set; }

        [Keyword("GASRATE=")]
        [UomVolumeRateNorn]
        public Meassure GasRate { get; set; }

        [Keyword("MASSRATE=")]
        [UomMassRate]
        public Meassure MassRate { get; set; }

        [Keyword("REBC=")]
        public string RemoveExistingBoundaryCondition { get; set; }

        [Keyword("CURVET=")]
        [UomLengthNorm]
        public Meassure Elevation { get; set; }

        [Keyword("ESTPRESSURE=")]
        [UomPressure]
        public Meassure EstPressure { get; set; }
    }

    public class SinkKeyword : IKeywordWriter
    {
        public SinkData Data { get; set; }

        public string Write(KeywordOptions options)
        {
            throw new NotImplementedException();
        }
    }
}