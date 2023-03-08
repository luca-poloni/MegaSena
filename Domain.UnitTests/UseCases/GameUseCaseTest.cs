using Domain.Factories;
using FluentAssertions;

namespace Domain.UnitTests.UseCases
{
    public sealed class GameUseCaseTest
    {
        [Fact]
        public void PlayMethod_WithValidInstance_ShouldNotThrow()
        {
            Action action = () =>
            {
                var betNumbers = new List<int> { 1, 2, 3, 4, 5, 6 };
                var gameRule = GameRuleFactory.Create();
                var bet = BetFactory.Create(betNumbers, gameRule);
                var prizeDraw = PrizeDrawFactory.Create(gameRule);
                var game = GameFactory.Create(bet, prizeDraw, gameRule);
                game.Play();
            };

            action.Should()
                .NotThrow();
        }
    }
}
