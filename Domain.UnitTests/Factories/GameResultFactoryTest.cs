using Domain.Factories;
using Domain.Interfaces;
using FluentAssertions;

namespace Domain.UnitTests.Factories
{
    public sealed class GameResultFactoryTest
    {
        [Fact]
        public void CreateGameResult_WithValidParameters_ShouldAsGameResult()
        {
            #region Arrange
            var amount = 10;
            var betNumbers = new List<int> { 10, 20, 30, 40, 50, 60 };
            var raffledNumbers = new List<int> { 10, 21, 31, 41, 55, 59 };
            var hits = 1;
            var prize = 50;
            #endregion

            #region Act
            var gameResult = GameResultFactory.Create(amount, betNumbers, raffledNumbers, hits, prize);
            #endregion

            #region Assert
            gameResult.Should().As<IGameResult>();
            #endregion
        }
    }
}
