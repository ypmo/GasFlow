using GasFlow.Sim.PipeSim.Keywords;
using System;
using Xunit;

namespace GasFlow.Sim.PipeSim.Test
{
    public class KeywodrdParametrTests
    {
        [Fact]
        public void DoubleToString()
        {
            var txt = new SimpleP<double>("KEY=", 5.1d).Write();
            Assert.Equal("KEY=5.1", txt);
        }

        [Fact]
        public void ExponentaToString()
        {
            var txt = new SimpleP<double>("KEY=", 0.00000000051d).Write();
            Assert.Equal("KEY=5.1E-10", txt);
        }

        [Fact]
        public void EnumWithOutAttributeToString()
        {
            var txt = new SimpleP<SimpleEnum>("KEY=", SimpleEnum.Uno).Write();
            Assert.Equal("KEY=Uno", txt);
        }

        [Fact]
        public void EnumWithAttributeToString()
        {
            var txt = new SimpleP<SimpleEnum>("KEY=", SimpleEnum.Duo).Write();
            Assert.Equal("KEY=TWO", txt);
        }

        [Fact]
        public void StringToString()
        {
            var txt = new SimpleP<string>("KEY=", "Simple").Write();
            Assert.Equal("KEY='Simple'", txt);
        }

        [Fact]
        public void NullToString()
        {
            var txt = new SimpleP<string>("KEY=", null).Write();
            Assert.Equal(string.Empty, txt);
        }

        [Fact]
        public void ArroyString()
        {
            var txt = new SimpleP<string[]>("KEY", new string[] { "a", "b" }).Write();
            Assert.Equal("KEY a b", txt);
        }

        public enum SimpleEnum
        {
            Uno,
            [Keyword("TWO")]
            Duo
        }
        
        [Fact]
        public void MeassureMustDoException()
        {
            var par = new SimpleP<Meassure>("KEY=", new Meassure() { Value = 0.0, Uom = "m" }); ;
            Assert.Throws<System.NotImplementedException>(() => par.Write());
        }
    }
}
