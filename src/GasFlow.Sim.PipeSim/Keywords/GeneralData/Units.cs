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
    public class UnitsKeyword : IEngineKeyword
    {
        public UnitsData Data { get; set; }
        KeywodrdParametr<UnitType?> Input => new("INPUT=", () => Data.Input);
        KeywodrdParametr<UnitType?> Output => new("OUTPUT=", () => Data.Output);
        KeywodrdParametr<UnitType?> All => new("ALL=", () => Data.All);

        public string WriteText(KeywordOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
