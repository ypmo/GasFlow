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
        public Meassure Dbean { get; set; }

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
        public Meassure PercentageTolerance { get; set; }

        /// <summary>
        /// Discharge coefficient (default = 0.6). This value is used to calculate the flow coefficient, CSP
        /// </summary>
        public double? DischargeCoefficient { get; set; }

        /// <summary>
        /// Flow coefficient. This is normally calculated by PIPESIM
        /// </summary>
        [Range(0, 1.3)]
        public double? FlowCoefficient { get; set; }
        [Range(0.7, 2)]
        public double? FluidSpecificHeatRatio { get; set; }

        /// <summary>
        /// (Default OFF). Allows detailed choke calculation output for the MECHANISTIC correlation.
        /// </summary>
        public OnOff? Verbose { get; set; }


        public Meassure PipeDia { get; set; }

        /// <summary>
        /// Maximum mass rate (lb/sec or Kg/sec).
        /// </summary>
        public Meassure MaxMassRate { get; set; }

        /// <summary>
        /// Maximum gas rate (mmscfd or mmsm3d).
        /// </summary>
        public Meassure MaxGasRate { get; set; }

        /// <summary>
        /// Maximum gross liquid rate (sbbl/day or sm3/day).
        /// </summary>
        public Meassure MaxGrossLiquidRate { get; set; }

        /// <summary>
        /// Maximum oil rate (sbbl/day or sm3/day).
        /// </summary>
        public Meassure MaxOilRate { get; set; }

        /// <summary>
        /// Maximum water rate (sbbl/day or sm3/day).
        /// </summary>
        public Meassure MaxWaterRate { get; set; }
    }

    public class ChokeKeyword : IKeywordWriter
    {
        ChokeData Data { get; set; }

        MeassureP Dbean => new("DBEAN=", new Uoms("mm", "inch"), () => Data.Dbean);
        SimpleP<CriticalFlowCorrelation?> CriticalCorrelation => new("CCORR=", () => Data.CriticalCorrelation);
        SimpleP<SubCriticalFlowCorrelation?> SubCriticalCorrelation => new("SCCORR=", () => Data.SubCriticalCorrelation);
        SimpleP<double?> CriticalPressureRatio => new("CPRATIO=", () => Data.CriticalPressureRatio);
        MeassureP PercentageTolerance => new("TOL=", new Uoms("%"), () => Data.PercentageTolerance);
        SimpleP<double?> DischargeCoefficient => new("CD=", () => Data.DischargeCoefficient);
        SimpleP<double?> FlowCoefficient => new("CSP=", () => Data.FlowCoefficient);
        SimpleP<double?> FluidSpecificHeatRatio => new("CPCV=", () => Data.FluidSpecificHeatRatio);
        SimpleP<OnOff?> Verbose => new("VERBOSE=", () => Data.Verbose);
        MeassureP PipeDia => new("PIPEID=", new Uoms("mm", "inch"), () => Data.PipeDia);
        MeassureP MaxMassRate => new("MAXMASS=", new Uoms("Kg/sec", "lb/sec"), () => Data.MaxMassRate);
        MeassureP MaxGasRate => new("MAXGAS=", new Uoms("mmsm3d", "mmscfd"), () => Data.MaxGasRate);
        MeassureP MaxGrossLiquidRate => new("MAXLIQUID=", new Uoms("sm3/day", "sbbl/day"), () => Data.MaxGrossLiquidRate);
        MeassureP MaxOilRate => new("MAXOIL=", new Uoms("sm3/day", "sbbl/day"), () => Data.MaxOilRate);
        MeassureP MaxWaterRate => new MeassureP("MAXWATER=", new Uoms("sm3/day", "sbbl/day"), () => Data.MaxWaterRate);

        public string Write(KeywordOptions options)
        {
            var uomSys = options.UomSystem;
            StringBuilder text = new();
            text.AppendLine("CHOKE")
                .AppendLine(Dbean, uomSys)
                .AppendLine(CriticalCorrelation);

            return text.ToString();
        }
    }




}
