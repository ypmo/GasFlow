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
}
