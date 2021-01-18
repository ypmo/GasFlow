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
        [Keyword("DBEAN=")]
        [UomLengthMini]
        public Meassure Dbean { get; set; }

        /// <summary>
        /// Selects the Critical flow correlation
        /// </summary> 
        [Keyword("CCORR=")]
        public CriticalFlowCorrelation? CriticalCorrelation { get; set; }

        /// <summary>
        /// Selects the required sub-critical flow correlation
        /// </summary>
        [Keyword("SCCORR=")]
        public SubCriticalFlowCorrelation? SubCriticalCorrelation { get; set; }

        /// <summary>
        /// Pressure ratio at which flow through choke becomes critical
        /// </summary>
        [Keyword("CPRATIO=")]
        public double? CriticalPressureRatio { get; set; }

        /// <summary>
        /// Percentage tolerance, for identification of critical flow conditions.
        /// </summary>
        [Keyword("TOL=")]
        [Uom("%")]
        public Meassure PercentageTolerance { get; set; }

        /// <summary>
        /// Discharge coefficient (default = 0.6). This value is used to calculate the flow coefficient, CSP
        /// </summary>
        [Keyword("CD=")]
        public double? DischargeCoefficient { get; set; }

        /// <summary>
        /// Flow coefficient. This is normally calculated by PIPESIM
        /// </summary>
        [Range(0, 1.3)]
        [Keyword("CSP=")]
        public double? FlowCoefficient { get; set; }
        [Range(0.7, 2)]
        [Keyword("CPCV=")]
        public double? FluidSpecificHeatRatio { get; set; }

        /// <summary>
        /// (Default OFF). Allows detailed choke calculation output for the MECHANISTIC correlation.
        /// </summary>
        [Keyword("VERBOSE")]
        public OnOff? Verbose { get; set; }

        [Keyword("PIPEID=")]
        [UomLengthMini]
        public Meassure PipeDia { get; set; }

        /// <summary>
        /// Maximum mass rate (lb/sec or Kg/sec).
        /// </summary>
        [Keyword("MAXMASS=")]
        [UomMassRate]
        public Meassure MaxMassRate { get; set; }

        /// <summary>
        /// Maximum gas rate (mmscfd or mmsm3d).
        /// </summary>
        [Keyword("MAXGAS=")]
        [UomVolumeRateNorn]
        public Meassure MaxGasRate { get; set; }

        /// <summary>
        /// Maximum gross liquid rate (sbbl/day or sm3/day).
        /// </summary>
        [Keyword("MAXLIQUID=")]
        [UomVolumeRateMini]
        public Meassure MaxGrossLiquidRate { get; set; }

        /// <summary>
        /// Maximum oil rate (sbbl/day or sm3/day).
        /// </summary>
        [Keyword("MAXOIL=")]
        [UomVolumeRateMini]
        public Meassure MaxOilRate { get; set; }

        /// <summary>
        /// Maximum water rate (sbbl/day or sm3/day).
        /// </summary>
        [Keyword("MAXWATER=")]
        [UomVolumeRateMini]
        public Meassure MaxWaterRate { get; set; }
    }

    public class ChokeKeyword : IKeywordWriter
    {
        ChokeData Data { get; set; }

        public string Write(KeywordOptions options)
        {
            var uomSys = options.UomSystem;
            StringBuilder text = new();
            text.AppendLine("CHOKE")
                .AppendLine(KeywordFactory.Create(Data, t => t.Dbean), uomSys)
                .AppendLine(KeywordFactory.Create(Data, t => t.CriticalCorrelation));

            return text.ToString();
        }
    }




}
