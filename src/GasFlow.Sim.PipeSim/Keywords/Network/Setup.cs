﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GasFlow.Sim.PipeSim.Keywords.Network
{
    public class SetupData
    {
        public string Title { get; set; }

    }
    public class SetupKeyword : IKeywordWriter<SetupData>
    {
        public SetupKeyword() { }
        protected SetupKeyword(SetupData data) { Data = data; }

        SetupData Data { get; set; }
        KeywodrdParametr<string> Title => new("TITLE=", );
        public string WriteText(SetupData data, KeywordOptions options)
        {
            throw new NotImplementedException();
        }
    }
}
