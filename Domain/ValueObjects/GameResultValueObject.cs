using Domain.Interfaces;

namespace Domain.ValueObjects
{
    internal sealed record GameResultValueObject : IGameResult
    {
        public decimal Amount { get; }
        public IEnumerable<int> BetNumbers { get; }
        public IEnumerable<int> RaffledNumbers { get; }
        public int Hits { get; }
        public decimal Prize { get; }

        public GameResultValueObject(decimal amount, IEnumerable<int> betNumbers, IEnumerable<int> raffledNumbers, int hits, decimal prize)
        {
            Amount = amount;
            BetNumbers = betNumbers;
            RaffledNumbers = raffledNumbers;
            Hits = hits;
            Prize = prize;
        }
    }
}
