using Domain.Interfaces;
using Domain.UseCases;

namespace Domain.Factories
{
    public class GameFactory
    {
        public static IGame Create(IBet bet, IPrizeDraw prizeDraw, IGameRule gameRule)
        {
            return new GameUseCase(bet, prizeDraw, gameRule);
        }
    }
}
