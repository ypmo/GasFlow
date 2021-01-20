using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.GeneralData
{
    public class JobData
    {
        [Keyword("JOB")]
        [MaxLength(70)]
        public string Job { get; set; }
    }

    public class JobWriter : IKeywordWriter
    {
        public JobData Data { get; set; }
        public string Write(KeywordOptions options)
        {
            StringBuilder sb = new();
            sb.AppendLine(Data, t => t.Job);
            return sb.ToString();
        }
    }
}
