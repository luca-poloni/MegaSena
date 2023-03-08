using Domain.Factories;
using Domain.Interfaces;
using FluentAssertions;

namespace Domain.UnitTests.Factories
{
    public sealed class GameFactoryTest
    {
        [Fact]
        public void CreateGame_WithValidParameters_ShouldAsGame()
        {
            #region Arrange
            var gameRule = GameRuleFactory.Create();
            var betNumbers = new List<int> { 10, 20, 30, 40, 50, 60 };
            var bet = BetFactory.Create(betNumbers, gameRule);
            var prizeDraw = PrizeDrawFactory.Create(gameRule);
            #endregion

            #region Act
            var game = GameFactory.Create(bet, prizeDraw, gameRule);
            #endregion

            #region Assert
            game.Should().As<IGame>();
            #endregion
        }
    }
}
