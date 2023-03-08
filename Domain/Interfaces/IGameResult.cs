namespace Domain.Interfaces
{
    public interface IGameResult
    {
        decimal Amount { get; }
        IEnumerable<int> BetNumbers { get; }
        IEnumerable<int> RaffledNumbers { get; }
        int Hits { get; }
        decimal Prize { get; }
    }
}
