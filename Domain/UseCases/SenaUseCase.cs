using Domain.Interfaces;

namespace Domain.UseCases
{
    internal sealed class SenaUseCase : IPrize
    {
        private readonly IGameRule _gameRule;

        public SenaUseCase(IGameRule gameRule)
        {
            _gameRule = gameRule;
        }

        public decimal Calculate()
        {
            return _gameRule.Amount;
        }
    }
}
