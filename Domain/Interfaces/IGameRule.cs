namespace Domain.Interfaces
{
    public interface IGameRule
    {
        int AmountNumbers { get; }
        int MinimumNumber { get; }
        int MaximumNumber { get; }
        decimal Amount { get; }
    }
}
