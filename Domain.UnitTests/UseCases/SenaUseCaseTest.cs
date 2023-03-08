using Domain.Factories;
using Domain.Interfaces;
using FluentAssertions;

namespace Domain.UnitTests.UseCases
{
    public sealed class SenaUseCaseTest
    {
        [Fact]
        public void CalculateMethod_WithHundredAmount_ShouldBeHundred()
        {
            #region Arrange
            var senaBet = 6;
            var gameRule = new GameRuleMock();
            var prize = PrizeFactory.Create(senaBet, gameRule);
            #endregion

            #region Act
            var prizeValue = prize.Calculate();
            #endregion

            #region Assert
            prizeValue.Should().Be(100);
            #endregion
        }

        private class GameRuleMock : IGameRule
        {
            public int AmountNumbers => throw new NotImplementedException();

            public int MinimumNumber => throw new NotImplementedException();

            public int MaximumNumber => throw new NotImplementedException();

            public decimal Amount { get; } = 100;
        }
    }
}
