using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.GeneralData
{
    public class UnitsData
    {
        [Keyword("INPUT=")]
        public UnitType? Input { get; set; }
        [Keyword("OUTPUT=")]
        public UnitType? Output { get; set; }
        [Keyword("ALL=")]
        public UnitType? All { get; set; }
    }
    public class UnitsKeyword
    {
        public UnitsData Data { get; set; }

        public string WriteText(KeywordOptions options)
        {
            StringBuilder sb = new();
            sb
                .AppendLine("UNITS")
                .AppendLine(Data, t => t.Input)
                .AppendLine(Data, t => t.Output)
                .AppendLine(Data, t => t.All);

            return sb.ToString();
        }
    }
}
