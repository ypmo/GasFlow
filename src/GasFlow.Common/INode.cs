namespace GasFlow
{
    public interface INode
    {
        IPort InpletPort { get; }
        IPort OutpletPort { get; }
    }
}