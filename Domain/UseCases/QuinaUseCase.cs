using Domain.Interfaces;

namespace Domain.UseCases
{
    internal sealed class QuinaUseCase : IPrize
    {
        private const decimal DISCOUNT = 0.2M;
        private readonly IGameRule _gameRule;

        public QuinaUseCase(IGameRule gameRule)
        {
            _gameRule = gameRule;
        }

        public decimal Calculate()
        {
            return _gameRule.Amount - (_gameRule.Amount * DISCOUNT);
        }
    }
}
