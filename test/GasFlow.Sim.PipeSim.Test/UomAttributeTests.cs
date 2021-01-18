using GasFlow.Sim.PipeSim.Keywords;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace GasFlow.Sim.PipeSim.Test
{
    public class UomAttributeTests
    {
        [Fact]
        public void UomAttributeUnoCtor()
        {
            var arr = new UomAttribute("uno");
            Assert.Equal("uno", arr.Uno);
            Assert.Null(arr.SI);
            Assert.Null(arr.ENG);
        }
        [Fact]
        public void UomAttributeDuoCtor()
        {
            var arr = new UomAttribute("1", "2");
            Assert.Equal("1", arr.SI);
            Assert.Equal("2", arr.ENG);
            Assert.Null(arr.Uno);
        }
    }
}
