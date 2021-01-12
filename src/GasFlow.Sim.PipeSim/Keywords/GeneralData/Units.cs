using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.GeneralData
{
    public class UnitsData
    {
        public UnitType? Input { get; set; }
        public UnitType? Output { get; set; }
        public UnitType? All { get; set; }
    }
    public class UnitsKeyword : IKeywordWriter
    {
        public UnitsData Data { get; set; }
        KeywordParametr<UnitType?> Input => new("INPUT=", () => Data.Input);
        KeywordParametr<UnitType?> Output => new("OUTPUT=", () => Data.Output);
        KeywordParametr<UnitType?> All => new("ALL=", () => Data.All);

        public string WriteText(KeywordOptions options)
        {

            throw new NotImplementedException();
        }
    }
}
