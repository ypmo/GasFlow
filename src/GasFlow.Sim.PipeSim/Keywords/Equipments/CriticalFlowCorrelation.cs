using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GasFlow.Sim.PipeSim.Keywords.Equipments
{
    public enum CriticalFlowCorrelation
    {
        /// <summary>
        /// Gilbert correlation
        /// </summary>
        [Keyword("GILBERT")]
        Gilbert,
        /// <summary>
        /// Ros correlation
        /// </summary>
        [Keyword("ROS")]
        Ros,
        /// <summary>
        /// Baxendell correlation
        /// </summary>
        [Keyword("BAXENDELL")]
        Baxendell,
        /// <summary>
        /// Achong correlation
        /// </summary>
        [Keyword("ACHONG")]
        Achong,
        /// <summary>
        /// Pilehvari correlation
        /// </summary>
        [Keyword("PILEHVARI")]
        Pilehvari,
        /// <summary>
        /// Ashford and Pierce correlation
        /// </summary>
        [Keyword("ASHFORD")]
        AshfordAndPierce,
        /// <summary>
        /// Sachdeva correlation
        /// </summary>
        [Keyword("ASHFORDT")]
        Sachdeva,
        /// <summary>
        /// Poetmann and Beck correlation
        /// </summary>
        [Keyword("POETBECK")]
        PoetmannAndBeck,
        /// <summary>
        /// Omana correlation
        /// </summary>
        [Keyword("OMANA")]
        Omana,
        /// <summary>
        /// (default) The MECHANISTIC choke
        /// </summary>
        [Keyword("MECHANISTIC")]
        MECHANISTIC,
        /// <summary>
        /// User-supplied correlation
        /// </summary>
        [Keyword("USER")]
        User

    }
}
