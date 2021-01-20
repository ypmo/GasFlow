using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.Equipments
{
    public class NodeData
    {
        [Keyword("DISTANCE=")]
        [UomLengthNorm]
        public Meassure Distance { get; set; }

        [Keyword("ELEVATION=")]
        [UomLengthNorm]
        public Meassure Elevation { get; set; }

        [Keyword("MD=")]
        [UomLengthNorm]
        public Meassure Md { get; set; }

        [Keyword("TVD=")]
        [UomLengthNorm]
        public Meassure Tvd { get; set; }

        [Keyword("TEMP=")]
        [UomTemperature]
        public Meassure AmbientTemperature { get; set; }

        [Keyword("U=")]
        [UomHeatTransfer]
        public Meassure HeatTransferCoefficient { get; set; }

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
            var uom = options.UomSystem;
            StringBuilder sb = new();
            sb.Append("NODE");

            var distans = KeywordFactory.Create(Data, t => t.Distance).Write(uom);
            var elevation = KeywordFactory.Create(Data, t => t.Elevation).Write(uom);
            var md = KeywordFactory.Create(Data, t => t.Md).Write(uom);
            var tvd = KeywordFactory.Create(Data, t => t.Md).Write(uom);

            return sb.ToString();
        }
    }
}