using Domain.Interfaces;

namespace Domain.UseCases
{
    internal sealed class GameRuleUseCase : IGameRule
    {
        public int AmountNumbers { get; } = 6;
        public int MinimumNumber { get; } = 1;
        public int MaximumNumber { get; } = 60;
        public decimal Amount { get; } = 6000000M;
    }
}
