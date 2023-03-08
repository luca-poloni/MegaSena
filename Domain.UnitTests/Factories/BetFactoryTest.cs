using Domain.Factories;
using Domain.Interfaces;
using FluentAssertions;

namespace Domain.UnitTests.Factories
{
    public sealed class BetFactoryTest
    {
        [Fact]
        public void CreateBet_WithValidParameters_ShouldAsBet()
        {
            #region Arrange
            var gameRule = GameRuleFactory.Create();
            var betNumbers = new List<int> { 10, 20, 30, 40, 50, 60 };
            #endregion

            #region Act
            var bet = BetFactory.Create(betNumbers, gameRule);
            #endregion

            #region Assert
            bet.Should().As<IBet>();
            #endregion
        }
    }
}
