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

            throw new NotImplementedException();
        }
    }
}
