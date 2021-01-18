using GasFlow.Sim.PipeSim.Keywords;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Xunit;

namespace GasFlow.Sim.PipeSim.Test
{
    public class KeywordExpressionTests
    {
        [Fact]
        public void Keyword()
        {
            Expression<Func<SimpleData, double?>> exp = (t) => t.Double;
            var par = exp.Keyword();
            Assert.Equal("DOUBLE=", par);
        }

        [Fact]
        public void UomSiEng()
        {
            Expression<Func<SimpleData, Meassure>> exp = (t) => t.Meassure;
            var uom = exp.Uoms();
            Assert.Equal("A", uom.SI);
            Assert.Equal("B", uom.ENG);
            Assert.Null(uom.Uno);
        }

        [Fact]
        public void UomUno()
        {
            Expression<Func<SimpleData, Meassure>> exp = (t) => t.UnoMeassure;
            var uom = exp.Uoms();
            Assert.Null(uom.SI);
            Assert.Null(uom.ENG);
            Assert.Equal("C", uom.Uno);
        }

        public class SimpleData
        {
            [Keyword("DOUBLE=")]
            public double? Double { get; set; }

            [Uom("A", "B")]
            public Meassure Meassure { get; set; }

            [Uom("C")]
            public Meassure UnoMeassure { get; set; }
        }
    }
}
