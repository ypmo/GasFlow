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
        KeywordParametr<double?> Distance => new("DISTANCE=", () => Data.Distance);
        KeywordParametr<double?> Elevation => new("ELEVATION=", () => Data.Elevation);
        KeywordParametr<double?> Md => new("MD=", () => Data.Md);
        KeywordParametr<double?> Tvd => new("TVD=", () => Data.Tvd);
        KeywordParametr<double?> AmbientTemperature => new("TEMP=", () => Data.AmbientTemperature);
        KeywordParametr<double?> HeatTransferCoefficient => new("U=", () => Data.HeatTransferCoefficient);
        KeywordParametr<string> Label => new("LABEL=", () => Data.Label);
        KeywordParametr<double?> MeasuredPressure => new("MPRESSURE=", () => Data.MeasuredPressure);
        KeywordParametr<double?> MeasuredTemperature => new("MTEMPERATURE=", () => Data.MeasuredTemperature);
        KeywordParametr<double?> MeasuredLiquidHoldup => new("MHOLDUP=", () => Data.MeasuredLiquidHoldup);
        public string WriteText(KeywordOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
