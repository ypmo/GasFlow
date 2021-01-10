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
    public class NodeKeyword : IEngineKeyword
    {
        NodeData Data { get; set; }
        KeywodrdParametr<double?> Distance => new("DISTANCE=", () => Data.Distance);
        KeywodrdParametr<double?> Elevation => new("ELEVATION=", () => Data.Elevation);
        KeywodrdParametr<double?> Md => new("MD=", () => Data.Md);
        KeywodrdParametr<double?> Tvd => new("TVD=", () => Data.Tvd);
        KeywodrdParametr<double?> AmbientTemperature => new("TEMP=", () => Data.AmbientTemperature);
        KeywodrdParametr<double?> HeatTransferCoefficient => new("U=", () => Data.HeatTransferCoefficient);
        KeywodrdParametr<string> Label => new("LABEL=", () => Data.Label);
        KeywodrdParametr<double?> MeasuredPressure => new("MPRESSURE=", () => Data.MeasuredPressure);
        KeywodrdParametr<double?> MeasuredTemperature => new("MTEMPERATURE=", () => Data.MeasuredTemperature);
        KeywodrdParametr<double?> MeasuredLiquidHoldup => new("MHOLDUP=", () => Data.MeasuredLiquidHoldup);
        public string WriteText()
        {
            throw new NotImplementedException();
        }
    }
}
