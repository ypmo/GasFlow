using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.GeneralData
{
    public class CaseData
    {
        [Keyword("CASE")]
        [MaxLength(70)]
        public string Case { get; set; }
    }
    public class CaseWriter : IKeywordWriter
    {
        public CaseData Data { get; set; }
        public string Write(KeywordOptions options)
        {
            StringBuilder sb = new();
            sb.AppendLine(Data, t => t.Case);
            return sb.ToString();
        }
    }
}
