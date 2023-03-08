using Domain.UseCases;
using Domain.Interfaces;

namespace Domain.Factories
{
    public static class PrizeFactory
    {
        public static IPrize Create(int hits, IGameRule gameRule)
        {
            switch (hits)
            {
                case 6:
                    return new SenaUseCase(gameRule);
                case 5:
                    return new QuinaUseCase(gameRule);
                case 4:
                    return new QuadraUseCase(gameRule);
                default:
                    return new NoPrizeUseCase();
            }
        }
    }
}
