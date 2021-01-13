using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.Network
{
    public class SetupData
    {
        public string Title { get; set; }

    }
    public class SetupKeyword : IKeywordWriter
    {
        public SetupKeyword() { }
        protected SetupKeyword(SetupData data) { Data = data; }

        SetupData Data { get; set; }
        SimpleP<string> Title => new("TITLE=", () => Data.Title);

        public string Write(KeywordOptions options)
        {
            StringBuilder sb = new();
            sb
                .AppendLine(Title);

            return sb.ToString();
        }

    }
}
