using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.Equipments
{
   public  class PipeData
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
}
