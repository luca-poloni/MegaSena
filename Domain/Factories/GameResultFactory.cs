using Domain.Interfaces;
using Domain.ValueObjects;

namespace Domain.Factories
{
    public static class GameResultFactory
    {
        public static IGameResult Create(decimal amount, IEnumerable<int> betNumbers, IEnumerable<int> raffledNumbers, int hits, decimal prize)
        {
            return new GameResultValueObject(amount, betNumbers, raffledNumbers, hits, prize);
        }
    }
}
