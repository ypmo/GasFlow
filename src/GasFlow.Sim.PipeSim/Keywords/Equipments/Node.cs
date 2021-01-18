using System;
using System.ComponentModel.DataAnnotations;

namespace GasFlow.Sim.PipeSim.Keywords.Equipments
{
    public class NodeData
    {
        [Keyword("DISTANCE=")]
        [Uom(SiLength.m, EngLength.ft)]
        public Meassure Distance { get; set; }

        [Keyword("ELEVATION=")]
        [Uom(SiLength.m, EngLength.ft)]
        public double? Elevation { get; set; }

        [Keyword("MD=")]
        [Uom(SiLength.m, EngLength.ft)]
        public double? Md { get; set; }

        [Keyword("TVD=")]
        [Uom(SiLength.m, EngLength.ft)]
        public double? Tvd { get; set; }

        [Keyword("TEMP=")]
        [Uom(SiTemp.C, EngTemp.F)]
        public double? AmbientTemperature { get; set; }

        [Keyword("U=")]
        [Uom(SiHeatTransfer.Wm2K, EngHeatTransfer.BtuHrFt2F)]
        public double? HeatTransferCoefficient { get; set; }

        [MaxLength(12)]
        [Keyword("LABEL=")]
        public string Label { get; set; }

        [Keyword("MPRESSURE=")]
        [Uom(SiPressure.bara, EngPressure.psia)]
        public Meassure MeasuredPressure { get; set; }

        [Keyword("MTEMPERATURE=")]
        [Uom(SiTemp.C, EngTemp.F)]
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