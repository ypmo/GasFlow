using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.GeneralData
{
    public class HeaderData
    {
        [Keyword("PROJECT=")]
        [MaxLength(12)]
        public string Project { get; set; }

        [Keyword("USER=")]
        [MaxLength(12)]
        public string User { get; set; }

        [Keyword("PASSWORD=")]
        [MaxLength(12)]
        public string Password { get; set; }
    }
    public class HeaderWriter : IKeywordWriter
    {
        public HeaderData Data { get; set; }
        public string Write(KeywordOptions options)
        {
            StringBuilder sb = new();
            sb
                .AppendLine("HEADER")
                .AppendLine(Data, t => t.Project)
                .AppendLine(Data, t => t.User)
                .AppendLine(Data, t => t.Password);
            throw new NotImplementedException();
        }
    }
}
