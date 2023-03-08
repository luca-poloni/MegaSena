using Domain.Interfaces;
using Domain.UseCases;

namespace Domain.Factories
{
    public static class PrizeDrawFactory
    {
        public static IPrizeDraw Create(IGameRule gameRule)
        {
            return new PrizeDrawUseCase(gameRule);
        }
    }
}
