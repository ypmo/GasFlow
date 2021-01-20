using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GasFlow.Sim.PipeSim.Keywords.Network
{
 public enum WolfMode
    {
        /// <summary>
        /// Disable WOFL mode.
        /// </summary>
        [XmlEnum("OFF")]
        Off,

        /// <summary>
        /// Enable WOFL mode, and unconditionally create WOFL files for all pressure-specified sources and production wells at the start of the simulation.
        /// </summary>
        [XmlEnum("CREATE")]
        Create,

        /// <summary>
        /// Enable WOFL mode. Read and validate any existing WOFL files, comparing the fluid definition, pressure boundary condition, and branch geometry in them to the corresponding values in the current model for the branch. If they match, use the file, otherwise re-create it.
        /// </summary>
        [XmlEnum("CREATE?")]
        CreateIfNeed,

        /// <summary>
        /// Enable WOFL mode. Unconditionally read any existing WOFL files and use them, despite possible mismatch between them and the current model settings. No new files will be created.
        /// </summary>
        [XmlEnum("USE")]
        Use
    }
}
