using System;
using System.ComponentModel.DataAnnotations;

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

        /// <summary>
        /// “Remove Existing Boundary Condition” for the sink. This is used when multiple SINK statements refer to the same named sink, and you want this statement to remove all boundary conditions for this sink specified with earlier statements.
        /// </summary>
        [Keyword("REBC=")]
        public string RemoveExistingBoundaryCondition { get; set; }

        /// <summary>
        /// Specifies that the sink is active
        /// </summary>
        [Keyword("")]
        [Required]
        public OnOff OnOff { get; set; }

        [Keyword("MAXMASS=")]
        [UomMassRate]
        public Meassure MaxMassRate { get; set; }

        [Keyword("MAXOIL=")]
        [UomVolumeRateMini]
        public Meassure MaxOilRate { get; set; }

        [Keyword("MAXGAS=")]
        [UomVolumeRateNorn]
        public Meassure MaxGasRate { get; set; }

        [Keyword("MAXWAT=")]
        [UomVolumeRateMini]
        public Meassure MaxWatterRate { get; set; }

        [Keyword("ELEVATION=")]
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