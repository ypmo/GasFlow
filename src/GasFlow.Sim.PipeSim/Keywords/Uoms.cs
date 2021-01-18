using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public class Uoms
    {
        public Uoms() { }

        public Uoms(string uno)
        {
            Uno = uno;
        }

        public Uoms(string si, string eng)
        {
            SI = si;
            ENG = eng;
        }

        public string SI { get; set; }
        public string ENG { get; set; }
        public string Uno { get; set; }



        public string Uom(UomSystem u) => Uom(u, SI, ENG, Uno);

        static string Uom(UomSystem u, string si, string eng, string uno) =>
              u switch
              {
                  UomSystem.Si => si ?? uno ?? default,
                  UomSystem.Eng => eng ?? uno ?? default,
                  _ => throw new NotImplementedException(),
              };
    }
}