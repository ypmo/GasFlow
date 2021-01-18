using System;

namespace GasFlow.Sim.PipeSim.Keywords.Equipments
{
    public class PipeData
    {
        /// <summary>
        /// Pipe Internal diameter
        /// </summary>
        [Keyword("ID=")]
        [Uom(SiLength.mm, EngLength.inch)]
        public Meassure InternalDiameter { get; set; }

        /// <summary>
        /// Pipe wall thickness
        /// </summary>
        [Keyword("WT=")]
        [Uom(SiLength.mm, EngLength.inch)]
        public Meassure WallThickness { get; set; }

        /// <summary>
        /// Pipe roughness
        /// </summary>
        [Keyword("ROUGHNESS=")]
        [Uom(SiLength.mm, EngLength.inch)]
        public Meassure Roughness { get; set; }

        /// <summary>
        /// Annulus inside Diameter
        /// </summary>
        [Keyword("AID=")]
        [Uom(SiLength.mm, EngLength.inch)]
        public Meassure AnnulusInsideDiameter { get; set; }

        /// <summary>
        /// Annulus Outside Diameter
        /// </summary>
        [Keyword("AOD=")]
        [Uom(SiLength.mm, EngLength.inch)]
        public Meassure AnnulusOutsideDiameter { get; set; }

        /// <summary>
        /// Specifies the flowpath for a tubing/annulus system.
        /// </summary>
        [Keyword("FLOWTYPE=")]
        public FlowType? FlowType { get; set; }

        /// <summary>
        /// Pipe thermal conductivity
        /// </summary>
        [Keyword("CONDUCTIVITY=")]
        [Uom(SiThermalConductivity.WmK, EngThermalConductivity.BtuHrFtF)]
        public Meassure Conductivity { get; set; }

        /// <summary>
        /// The thickness of a coating of wax that exists on the inside of the pipe
        /// </summary>
        [Keyword("WAXTHICKNESS=")]
        [Uom(SiLength.mm, EngLength.inch)]
        public Meassure WaxThickness { get; set; }

        /// <summary>
        /// The thermal Conductivity of the wax (
        /// </summary>
        [Keyword("WAXK=")]
        [Uom(SiThermalConductivity.WmK, EngThermalConductivity.BtuHrFtF)]
        public Meassure WaxConductivity { get; set; }

        /// <summary>
        /// Drive rod diameter.
        /// </summary>
        [Keyword("RODDIAM=")]
        [Uom(SiLength.mm, EngLength.inch)]
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
        MeassureP InLineHeater => new("ILHMAXPOWER=", new Uoms("Kw/m", "BTU/hr/ft"), Data.InLineHeater);
        MeassureP MinimumTemperature => new("ILHMINTEMP=", new Uoms("Kw/m", "BTU/hr/ft"), Data.MinimumTemperature);

        public string Write(KeywordOptions options)
        {
            throw new NotImplementedException();
        }
    }
}