using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Serialization;
namespace GasFlow.Sim.PipeSim.Keywords.Equipments
{
    public class ChokeData
    {
        /// <summary>
        /// Required. Diameter of the choke bean (mm or inches)
        /// </summary>
        [Required]
        public double Dbean { get; set; }

        /// <summary>
        /// Selects the Critical flow correlation
        /// </summary> 
        public CriticalFlowCorrelation? CriticalCorrelation { get; set; }

        /// <summary>
        /// Selects the required sub-critical flow correlation
        /// </summary>
        public SubCriticalFlowCorrelation? SubCriticalCorrelation { get; set; }

        /// <summary>
        /// Pressure ratio at which flow through choke becomes critical
        /// </summary>
        public double? CriticalPressureRatio { get; set; }

        /// <summary>
        /// Percentage tolerance, for identification of critical flow conditions.
        /// </summary>
        public double? PercentageTolerance { get; set; }

        /// <summary>
        /// Discharge coefficient (default = 0.6). This value is used to calculate the flow coefficient, CSP
        /// </summary>
        public double? DischargeCoefficient { get; set; }

        /// <summary>
        /// Flow coefficient. This is normally calculated by PIPESIM
        /// </summary>
        public double? FlowCoefficient { get; set; }

        public double? FluidSpecificHeatRatio { get; set; }

        /// <summary>
        /// (Default OFF). Allows detailed choke calculation output for the MECHANISTIC correlation.
        /// </summary>
        public OnOff? Verbose { get; set; }


        public double? PipeDia { get; set; }

        /// <summary>
        /// Maximum mass rate (lb/sec or Kg/sec).
        /// </summary>
        public double? MaxMassRate { get; set; }

        /// <summary>
        /// Maximum gas rate (mmscfd or mmsm3d).
        /// </summary>
        public double? MaxGasRate { get; set; }

        /// <summary>
        /// Maximum gross liquid rate (sbbl/day or sm3/day).
        /// </summary>
        public double? MaxGrossLiquidRate { get; set; }

        /// <summary>
        /// Maximum oil rate (sbbl/day or sm3/day).
        /// </summary>
        public double? MaxOilRate { get; set; }

        /// <summary>
        /// Maximum water rate (sbbl/day or sm3/day).
        /// </summary>
        public double? MaxWaterRate { get; set; }
    }

    public class ChokeKeyword : IEngineKeyword
    {
        ChokeData Data { get; set; }

        KeywodrdParametr<double> DBEAN => new("DBEAN=", () => Data.Dbean, (v) => true);
        KeywodrdParametr<CriticalFlowCorrelation?> CriticalCorrelation => new("CCORR=", () => Data.CriticalCorrelation);
        KeywodrdParametr<SubCriticalFlowCorrelation?> SubCriticalCorrelation => new("SCCORR=", () => Data.SubCriticalCorrelation);
        KeywodrdParametr<double?> CriticalPressureRatio => new("CPRATIO=", () => Data.CriticalPressureRatio);
        KeywodrdParametr<double?> PercentageTolerance => new("TOL=", () => Data.PercentageTolerance);
        KeywodrdParametr<double?> DischargeCoefficient => new("CD=", () => Data.DischargeCoefficient);
        KeywodrdParametr<double?> FlowCoefficient => new("CSP=", () => Data.FlowCoefficient);
        KeywodrdParametr<double?> FluidSpecificHeatRatio => new("CPCV=", () => Data.FluidSpecificHeatRatio);
        KeywodrdParametr<OnOff?> Verbose => new("VERBOSE=", () => Data.Verbose);
        KeywodrdParametr<double?> PipeDia => new("PIPEID=", () => Data.PipeDia);
        KeywodrdParametr<double?> MaxMassRate => new("MAXMASS=", () => Data.MaxMassRate);
        KeywodrdParametr<double?> MaxGasRate => new("MAXGAS=", () => Data.MaxGasRate);
        KeywodrdParametr<double?> MaxGrossLiquidRate => new("MAXLIQUID=", () => Data.MaxGrossLiquidRate);
        KeywodrdParametr<double?> MaxOilRate => new("MAXOIL=", () => Data.MaxOilRate);
        KeywodrdParametr<double?> MaxWaterRate => new("MAXWATER=", () => Data.MaxWaterRate);

        public string WriteText()
        {
            StringBuilder text = new();
            text.AppendLine("CHOKE")
                .AppendLine(DBEAN)
                .AppendLine(CriticalCorrelation);

            return text.ToString();
        }

    }
}
