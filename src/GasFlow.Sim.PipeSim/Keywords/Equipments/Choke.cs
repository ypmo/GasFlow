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
        public double? PercentageTolerance { get; set; }

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

        [Meassure(ENG = "inch", SI = "mm")]
        public IKeywordParametr Dbean => new KeywordParametr<Meassure>("DBEAN=", () => Data.Dbean, (v) => true);

        public IKeywordParametr CriticalCorrelation => new KeywordParametr<CriticalFlowCorrelation?>("CCORR=", () => Data.CriticalCorrelation);
        public IKeywordParametr SubCriticalCorrelation => new KeywordParametr<SubCriticalFlowCorrelation?>("SCCORR=", () => Data.SubCriticalCorrelation);
        public IKeywordParametr CriticalPressureRatio => new KeywordParametr<double?>("CPRATIO=", () => Data.CriticalPressureRatio);
        [Meassure(Uno = "%")]
        public IKeywordParametr PercentageTolerance => new KeywordParametr<double?>("TOL=", () => Data.PercentageTolerance);
        public IKeywordParametr DischargeCoefficient => new KeywordParametr<double?>("CD=", () => Data.DischargeCoefficient);
        public IKeywordParametr FlowCoefficient => new KeywordParametr<double?>("CSP=", () => Data.FlowCoefficient);
        public IKeywordParametr FluidSpecificHeatRatio => new KeywordParametr<double?>("CPCV=", () => Data.FluidSpecificHeatRatio);
        public IKeywordParametr Verbose => new KeywordParametr<OnOff?>("VERBOSE=", () => Data.Verbose);

        [Meassure(ENG = "inch", SI = "mm")]
        public IKeywordParametr PipeDia => new KeywordParametr<Meassure>("PIPEID=", () => Data.PipeDia);

        [Meassure(ENG = "lb/sec", SI = "Kg/sec")]
        public IKeywordParametr MaxMassRate => new KeywordParametr<Meassure>("MAXMASS=", () => Data.MaxMassRate);

        [Meassure(ENG = "mmscfd", SI = "mmsm3d")]
        public IKeywordParametr MaxGasRate => new KeywordParametr<Meassure>("MAXGAS=", () => Data.MaxGasRate);

        [Meassure(ENG = "sbbl/day", SI = "sm3/day")]
        public IKeywordParametr MaxGrossLiquidRate => new KeywordParametr<Meassure>("MAXLIQUID=", () => Data.MaxGrossLiquidRate);

        [Meassure(ENG = "sbbl/day", SI = "sm3/day")]
        public IKeywordParametr MaxOilRate => new KeywordParametr<Meassure>("MAXOIL=", () => Data.MaxOilRate);

        [Meassure(ENG = "sbbl/day", SI = "sm3/day")]
        public IKeywordParametr MaxWaterRate => new KeywordParametr<Meassure>("MAXWATER=", () => Data.MaxWaterRate);

        public string Write(KeywordOptions options)
        {
            StringBuilder text = new();
            text.AppendLine("CHOKE")
                .AppendLine(Dbean)
                .AppendLine(CriticalCorrelation);

            return text.ToString();
        }
    }
}
