namespace GasFlow
{
    public interface IModel
    {
        int Id { get; }
        INetwork Network { get; }
    }
}