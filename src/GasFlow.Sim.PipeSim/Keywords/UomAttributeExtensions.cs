namespace GasFlow.Sim.PipeSim.Keywords
{
    public static class UomAttributeExtensions
    {
        public static Uoms Uoms(this UomAttribute attribute)
        {
            return new Uoms() { SI = attribute.SI, ENG = attribute.ENG, Uno = attribute.Uno };
        }
    }
}
