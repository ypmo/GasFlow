using System;
using System.ComponentModel.DataAnnotations;

namespace GasFlow.Sim.PipeSim.Keywords.Equipments
{
    public class NodeData
    {
        [Keyword("DISTANCE=")]
        [UomLengthNorm]
        public Meassure Distance { get; set; }

        [Keyword("ELEVATION=")]
        [UomLengthNorm]
        public double? Elevation { get; set; }

        [Keyword("MD=")]
        [UomLengthNorm]
        public double? Md { get; set; }

        [Keyword("TVD=")]
        [UomLengthNorm]
        public double? Tvd { get; set; }

        [Keyword("TEMP=")]
        [UomTemperature]
        public double? AmbientTemperature { get; set; }

        [Keyword("U=")]
        [UomHeatTransfer]
        public double? HeatTransferCoefficient { get; set; }

        [MaxLength(12)]
        [Keyword("LABEL=")]
        public string Label { get; set; }

        [Keyword("MPRESSURE=")]
        [UomPressure]
        public Meassure MeasuredPressure { get; set; }

        [Keyword("MTEMPERATURE=")]
        [UomTemperature]
        public Meassure MeasuredTemperature { get; set; }

        [Keyword("MHOLDUP=")]
        public double? MeasuredLiquidHoldup { get; set; }
    }

    public class NodeKeyword : IKeywordWriter
    {
        private NodeData Data { get; set; }

        public string Write(KeywordOptions options)
        {
            throw new NotImplementedException();
        }
    }
}