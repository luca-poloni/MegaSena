using Domain.Interfaces;
using Domain.UseCases;

namespace Domain.Factories
{
    public static class GameRuleFactory
    {
        public static IGameRule Create()
        {
            return new GameRuleUseCase();
        }
    }
}
