using Domain.Interfaces;
using Domain.UseCases;

namespace Domain.Factories
{
    public static class BetFactory
    {
        public static IBet Create(IEnumerable<int> betNumbers, IGameRule gameRule)
        {
            return new BetUseCase(betNumbers, gameRule);
        }
    }
}
