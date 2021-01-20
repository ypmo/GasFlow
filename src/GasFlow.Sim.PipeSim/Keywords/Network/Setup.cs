using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.Network
{
    public class SetupData
    {
        /// <summary>
        /// The model title.
        /// </summary>
        [Keyword("TITLE=")]
        public string Title { get; set; }

        /// <summary>
        /// The overall tolerance of the converged network solution. Must be between 0.5 and 1e-6, default 0.01.
        /// </summary>
        [Keyword("TOLERANCE=")]
        [Range(1e-6, 0.5)]
        public double? Tolerance { get; set; }

        /// <summary>
        /// The maximum allowable number of overall network iterations. Must be between 3 and 1000, default 100.
        /// </summary>
        [Keyword("MAXITER=")]
        [Range(3, 100)]
        public int? MaxIteration { get; set; }

        /// <summary>
        /// An override on the type of fluid model to use. This is not normally required, as it is obtained from the fluid definitions supplied in the branch files, but can be supplied here if desired.
        /// </summary>
        [Keyword("FLUIDMODEL=")]
        public FluidModel? FluidModel { get; set; }

        /// <summary>
        /// How to treat unstable wells.
        /// </summary>
        [Keyword("UNSTABLEWELL=")]
        public WellOperation? UnStableWell { get; set; }

        /// <summary>
        /// How to treat redundant Reciprocating Compressor (recips). 
        /// </summary>
        [Keyword("RECIPBYPASS=")]
        public OnOff? RecipByPass { get; set; }

        /// <summary>
        /// The choice of network solution algorithm.
        /// </summary>
        [Keyword("ALGORITHM=")]
        public Algorithm? Algorithm { get; set; }

        /// <summary>
        /// Global settings for Wells Off Line Mode.
        /// </summary>
        [Keyword("WOFLMODE=")]
        public WolfMode? WoflMode { get; set; }

        /// <summary>
        /// Allows the contents of all well and branch geometry files to be echoed to the network output file. Can be set to YES or NO, default NO.
        /// </summary>
        [Keyword("ECHOBRANCH=")]
        public YesNo? Echobranch { get; set; }

        /// <summary>
        /// Controls the “skipping” (i.e., omission of processing) of geometry files for inactive branches: can be set to YES or NO. 
        /// </summary>
        [Keyword("SKIPINACTIVE=")]
        public YesNo? SKIPINACTIVE { get; set; }

        [Keyword("RESTARTINTERVAL=")]
        public int? RestartInterval { get; set; }

        /// <summary>
        ///  Controls the echo of the network input data to the output file. can be set to YES or NO, default YES. 
        /// </summary>
        [Keyword("ECHONET=")]
        public YesNo? EchoNet { get; set; }

    }
    public class SetupKeyword : IKeywordWriter
    {
        SetupData Data { get; set; }


        public string Write(KeywordOptions options)
        {
            StringBuilder sb = new();
            sb
                .AppendLine(KeywordFactory.Create(Data, t => t.Title));

            return sb.ToString();
        }

    }
}
