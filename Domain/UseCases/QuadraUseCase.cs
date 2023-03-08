using Domain.Interfaces;

namespace Domain.UseCases
{
    internal sealed class QuadraUseCase : IPrize
    {
        private const decimal DISCOUNT = 0.5M;
        private readonly IGameRule _gameRule;

        public QuadraUseCase(IGameRule gameRule)
        {
            _gameRule = gameRule;
        }

        public decimal Calculate()
        {
            return _gameRule.Amount - (_gameRule.Amount * DISCOUNT);
        }
    }
}
