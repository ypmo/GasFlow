namespace GasFlow
{
    public interface IModel : IEntity
    {
        INetwork Network { get; }
    }
}