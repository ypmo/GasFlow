using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.Equipments
{
    public class PipeData
    {
        /// <summary>
        /// Pipe Internal diameter 
        /// </summary>
        public Meassure InternalDiameter { get; set; }
        /// <summary>
        /// Pipe wall thickness 
        /// </summary>
        public Meassure WallThickness { get; set; }
        /// <summary>
        /// Pipe roughness 
        /// </summary>
        public Meassure Roughness { get; set; }
        /// <summary>
        /// Annulus inside Diameter 
        /// </summary>
        public Meassure AnnulusInsideDiameter { get; set; }
        /// <summary>
        /// Annulus Outside Diameter 
        /// </summary>
        public Meassure AnnulusOutsideDiameter { get; set; }
        /// <summary>
        /// Specifies the flowpath for a tubing/annulus system.
        /// </summary>
        public FlowType? FlowType { get; set; }
        /// <summary>
        /// Pipe thermal conductivity
        /// </summary>
        public Meassure Conductivity { get; set; }
        /// <summary>
        /// The thickness of a coating of wax that exists on the inside of the pipe 
        /// </summary>
        public Meassure WaxThickness { get; set; }
        /// <summary>
        /// The thermal Conductivity of the wax (
        /// </summary>
        public Meassure WaxConductivity { get; set; }
        /// <summary>
        /// Drive rod diameter.
        /// </summary>
        public Meassure DriveRodDiameter { get; set; }

        /// <summary>
        /// In-Line Heater
        /// </summary>
        public Meassure InLineHeater { get; set; }

        /// <summary>
        /// This subcode allows a fixed minimum temperature to be maintained across the pipeline by assigning required variable heating power per unit length of pipe
        /// </summary>
        public Meassure MinimumTemperature { get; set; }
    }

    public class PipeKeyword : IKeywordWriter
    {
        public PipeData Data { get; set; }
        MeassureP InternalDiameter => new("ID=", new Uoms("mm", "inch"), Data.InternalDiameter);
        MeassureP WallThickness => new("WT=", new Uoms("mm", "inch"), Data.WallThickness);
        MeassureP Roughness => new("ROUGHNESS=", new Uoms("mm", "inch"), Data.Roughness);
        MeassureP AnnulusInsideDiameter => new("AID=", new Uoms("mm", "inch"), Data.AnnulusInsideDiameter);
        MeassureP AnnulusOutsideDiameter => new("AOD=", new Uoms("mm", "inch"), Data.AnnulusOutsideDiameter);
        SimpleP<FlowType?> FlowType => new("ID=", Data.FlowType);
        MeassureP Conductivity => new("CONDUCTIVITY=", new Uoms("W/m/K", "Btu/hr/ft/F"), Data.Conductivity);
        MeassureP WaxThickness => new("WAXTHICKNESS=", new Uoms("mm", "inch"), Data.WaxThickness);
        MeassureP WaxConductivity => new("WAXK=", new Uoms("W/m/K", "Btu/hr/ft/F"), Data.WaxConductivity);
        MeassureP DriveRodDiameter => new("RODDIAM=", new Uoms("mm", "inch"), Data.DriveRodDiameter);
        MeassureP InLineHeater => new("ILHMAXPOWER=", new Uoms("Kw/m", "BTU/hr/ft"), Data.InLineHeater);
        MeassureP MinimumTemperature => new("ILHMINTEMP=", new Uoms("Kw/m", "BTU/hr/ft"), Data.MinimumTemperature);

        public string Write(KeywordOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
