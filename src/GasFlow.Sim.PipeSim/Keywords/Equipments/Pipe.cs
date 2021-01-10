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
    public class PipeKeyword : IEngineKeyword
    {
        public PipeData Data { get; set; }
        KeywodrdParametr<double> InternalDiameter => new("ID=", () => Data.InternalDiameter);
        KeywodrdParametr<double?> WallThickness => new("WT=", () => Data.WallThickness);
        KeywodrdParametr<double?> Roughness => new("ROUGHNESS=", () => Data.Roughness);
        KeywodrdParametr<double?> AnnulusInsideDiameter => new("AID=", () => Data.AnnulusInsideDiameter);
        KeywodrdParametr<double?> AnnulusOutsideDiameter => new("AOD=", () => Data.AnnulusOutsideDiameter);
        KeywodrdParametr<FlowType?> FlowType => new("ID=", () => Data.FlowType);
        KeywodrdParametr<double?> Conductivity => new("CONDUCTIVITY=", () => Data.Conductivity);
        KeywodrdParametr<double?> WaxThickness => new("WAXTHICKNESS=", () => Data.WaxThickness);
        KeywodrdParametr<double?> WaxConductivity => new("WAXK=", () => Data.WaxConductivity);
        KeywodrdParametr<double?> DriveRodDiameter => new("RODDIAM=", () => Data.DriveRodDiameter);

        public string WriteText()
        {
            throw new NotImplementedException();
        }
    }
}
