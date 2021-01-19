using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.Network
{
    public class SetupData
    {
        [Keyword("TITLE=")]
        public string Title { get; set; }

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
