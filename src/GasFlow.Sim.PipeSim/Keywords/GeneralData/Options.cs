using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.GeneralData
{
    public class OptionsData
    {
        [Keyword("SEGMENTS=")]
        public int? Segments { get; set; }

        [Keyword("MAXSEGLEN=")]
        [UomLength(SiLength.m, EngLength.ft)]
        public Meassure MaxSegLength { get; set; }

        [Keyword("MINSEGLEN=")]
        [UomLength(SiLength.m, EngLength.ft)]
        public Meassure MinSegLength { get; set; }

        [Keyword("EOFS=")]
        public OnOff? ExtraOneFootSegments { get; set; }

    }
    public class OptiontsWriter : IKeywordWriter
    {
        public OptionsData Data { get; set; }

        public string Write(KeywordOptions options)
        {
            var uom = options.UomSystem;
            StringBuilder sb = new();
            sb
                .AppendLine(KeywordFactory.Create(Data, d => d.Segments))
                .AppendLine(KeywordFactory.Create(Data, d => d.MaxSegLength), uom)
                .AppendLine(KeywordFactory.Create(Data, d => d.MinSegLength), uom)
                .AppendLine(KeywordFactory.Create(Data, d => d.ExtraOneFootSegments));

            return sb.ToString();
        }
    }
}
