using System;

namespace GasFlow.Sim.PipeSim.Keywords.Network
{
    public class SourceData
    {
        [Keyword("NAME=")]
        public string Name { get; set; }

        [Keyword("PRESSURE=")]
        [UomPressure]
        public Meassure Pressure { get; set; }

        [Keyword("TEMPERATURE=")]
        [UomTemperature]
        public Meassure Temperature { get; set; }

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

        [Keyword("CURVEP=")]
        [UomPressure]
        public MeassureArray CurvePressure { get; set; }

        [Keyword("CURVEL=")]
        [UomVolumeRateMini]
        public MeassureArray CurveLiquidRate { get; set; }

        [Keyword("CURVEG=")]
        [UomVolumeRateNorn]
        public MeassureArray CurveGasRate { get; set; }

        [Keyword("CURVEM=")]
        [UomMassRate]
        public MeassureArray CurveMassRate { get; set; }

        [Keyword("CURVET=")]
        [UomTemperature]
        public MeassureArray CurveTemperature { get; set; }

        [Keyword("CURVEFILE=")]
        public string CurveFile { get; set; }

        [Keyword("ELEVATION=")]
        [UomLengthNorm]
        public Meassure Elevation { get; set; }

        [Keyword("ESTPRESSURE=")]
        [UomPressure]
        public Meassure EstPressure { get; set; }
    }

    public class SourceKeyword : IKeywordWriter
    {
        public SourceData Data { get; set; }

        public string Write(KeywordOptions options)
        {
            throw new NotImplementedException();
        }
    }
}