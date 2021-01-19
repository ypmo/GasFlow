using System;

namespace GasFlow.Sim.PipeSim.Keywords.Equipments
{
    public class PipeData
    {
        /// <summary>
        /// Pipe Internal diameter
        /// </summary>
        [Keyword("ID=")]
        [UomLengthMini]
        public Meassure InternalDiameter { get; set; }

        /// <summary>
        /// Pipe wall thickness
        /// </summary>
        [Keyword("WT=")]
        [UomLengthMini]
        public Meassure WallThickness { get; set; }

        /// <summary>
        /// Pipe roughness
        /// </summary>
        [Keyword("ROUGHNESS=")]
        [UomLengthMini]
        public Meassure Roughness { get; set; }

        /// <summary>
        /// Annulus inside Diameter
        /// </summary>
        [Keyword("AID=")]
        [UomLengthMini]
        public Meassure AnnulusInsideDiameter { get; set; }

        /// <summary>
        /// Annulus Outside Diameter
        /// </summary>
        [Keyword("AOD=")]
        [UomLengthMini]
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
        [UomThermalConductivity]
        public Meassure Conductivity { get; set; }

        /// <summary>
        /// The thickness of a coating of wax that exists on the inside of the pipe
        /// </summary>
        [Keyword("WAXTHICKNESS=")]
        [UomLengthMini]
        public Meassure WaxThickness { get; set; }

        /// <summary>
        /// The thermal Conductivity of the wax (
        /// </summary>
        [Keyword("WAXK=")]
        [UomThermalConductivity]
        public Meassure WaxConductivity { get; set; }

        /// <summary>
        /// Drive rod diameter.
        /// </summary>
        [Keyword("RODDIAM=")]
        [UomLengthMini]
        public Meassure DriveRodDiameter { get; set; }

        /// <summary>
        /// In-Line Heater
        /// </summary>
        [Keyword("ILHMAXPOWER=")]
        [UomPowerPerLength]
        public Meassure InLineHeater { get; set; }

        /// <summary>
        /// This subcode allows a fixed minimum temperature to be maintained across the pipeline by assigning required variable heating power per unit length of pipe
        /// </summary>
        [Keyword("ILHMAXPOWER=")]
        [UomPowerPerLength]
        public Meassure MinimumTemperature { get; set; }
    }

    public class PipeKeyword : IKeywordWriter
    {
        public PipeData Data { get; set; }

        public string Write(KeywordOptions options)
        {
            throw new NotImplementedException();
        }
    }
}