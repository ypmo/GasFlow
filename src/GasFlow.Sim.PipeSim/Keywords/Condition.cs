using System;

namespace GasFlow.Sim.PipeSim.Keywords
{
    public class Condition
    {
        public Meassure Pressure { get; set; }
        public Meassure Temperature { get; set; }
    }

    public static class Condition_Extensions
    {
        //TODO Поддержка различных единиц измерения
        public static double ConvertVolumeToCondition(this Condition c0, double volume0, Condition c1)
        {
            if (c0.Pressure.Uom != c1.Pressure.Uom || c0.Temperature.Uom != c1.Temperature.Uom)
            {
                throw new ArithmeticException("Both uoms must be equals");
            }

            var p0 = c0.Pressure.Value;
            var p1 = c1.Pressure.Value;
            var t0 = c0.Temperature.Value;
            var t1 = c1.Temperature.Value;

            return ConvertVolumeToCondition(volume0, p0, t0, p1, t1);
        }

        public static double ConvertVolumeToCondition(this double volume0, double p0, double t0, double p1, double t1)
        {
            return volume0 * (p0 * t1) / (p1 * t0);
        }
    }
}
