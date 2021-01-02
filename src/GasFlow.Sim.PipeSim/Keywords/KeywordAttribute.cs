using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public class KeywordAttribute : Attribute
    {
        public KeywordAttribute(string keyword)
        {
            Keyword = keyword;
        }
        public string Keyword { get; }
    }
}
