using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.Equipments
{
    public class PipeData
    {
        [Required]
        public double InternalDiameter { get; set; }
        public double? WallThickness { get; set; }
        public double? Roughness { get; set; }
        public double? AnnulusInsideDiameter { get; set; }
        public double? AnnulusOutsideDiameter { get; set; }
        public FlowType? FlowType { get; set; }
        public double? Conductivity { get; set; }
        public double? WaxThickness { get; set; }
        public double? WaxConductivity { get; set; }
        public double? DriveRodDiameter { get; set; }
    }
    public class PipeKeyword : IKeywordWriter
    {
        public PipeData Data { get; set; }
        KeywordParametr<double> InternalDiameter => new("ID=", () => Data.InternalDiameter);
        KeywordParametr<double?> WallThickness => new("WT=", () => Data.WallThickness);
        KeywordParametr<double?> Roughness => new("ROUGHNESS=", () => Data.Roughness);
        KeywordParametr<double?> AnnulusInsideDiameter => new("AID=", () => Data.AnnulusInsideDiameter);
        KeywordParametr<double?> AnnulusOutsideDiameter => new("AOD=", () => Data.AnnulusOutsideDiameter);
        KeywordParametr<FlowType?> FlowType => new("ID=", () => Data.FlowType);
        KeywordParametr<double?> Conductivity => new("CONDUCTIVITY=", () => Data.Conductivity);
        KeywordParametr<double?> WaxThickness => new("WAXTHICKNESS=", () => Data.WaxThickness);
        KeywordParametr<double?> WaxConductivity => new("WAXK=", () => Data.WaxConductivity);
        KeywordParametr<double?> DriveRodDiameter => new("RODDIAM=", () => Data.DriveRodDiameter);

        public string WriteText(KeywordOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
