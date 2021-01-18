using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.Equipments
{
    public class NodeData
    {
        public double? Distance { get; set; }
        public double? Elevation { get; set; }
        public double? Md { get; set; }
        public double? Tvd { get; set; }
        public double? AmbientTemperature { get; set; }
        public double? HeatTransferCoefficient { get; set; }
        [MaxLength(12)]
        public string Label { get; set; }
        public double? MeasuredPressure { get; set; }
        public double? MeasuredTemperature { get; set; }
        public double? MeasuredLiquidHoldup { get; set; }
    }
    public class NodeKeyword : IKeywordWriter
    {
        NodeData Data { get; set; }
        SimpleP<double?> Distance => new("DISTANCE=", Data.Distance);
        SimpleP<double?> Elevation => new("ELEVATION=", Data.Elevation);
        SimpleP<double?> Md => new("MD=", Data.Md);
        SimpleP<double?> Tvd => new("TVD=", Data.Tvd);
        SimpleP<double?> AmbientTemperature => new("TEMP=", Data.AmbientTemperature);
        SimpleP<double?> HeatTransferCoefficient => new("U=", Data.HeatTransferCoefficient);
        SimpleP<string> Label => new("LABEL=", Data.Label);
        SimpleP<double?> MeasuredPressure => new("MPRESSURE=", Data.MeasuredPressure);
        SimpleP<double?> MeasuredTemperature => new("MTEMPERATURE=", Data.MeasuredTemperature);
        SimpleP<double?> MeasuredLiquidHoldup => new("MHOLDUP=", Data.MeasuredLiquidHoldup);

        public string Write(KeywordOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
