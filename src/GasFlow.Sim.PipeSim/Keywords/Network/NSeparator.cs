using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.Network
{
   public  class NSeparatorData
    {
        /// <summary>
        /// Name of the separator
        /// </summary>
        [Keyword("NAME=")]
        public string Name { get; set; }

        /// <summary>
        /// Name of the branch feeding the separator
        /// </summary>
        [Keyword("FEEDBRANCH=")]
        public string FeedBranche { get; set; }

        /// <summary>
        /// Name of the branch to receive the “discarded” stream. See note 1.
        /// </summary>
        [Keyword("DISCARDBRANCH=")]
        public string DiscardBranch { get; set; }

        /// <summary>
        /// The phase of the “discarded” stream: may be GAS, LIQUID, or WATER. See note 1.
        /// </summary>
        [Keyword("TYPE=")]
        public StreamType? Type { get; set; }

        /// <summary>
        /// Separator pressure (psia or bara). This is optiona
        /// </summary>
        [Keyword("PRESSURE=")]
        [UomPressure ]
        public Meassure Pressure { get; set; }

        [Keyword("EFFICIENCY=")]
        [Range(10,100)]
        public double? Efficiency { get; set; }
    }
}
