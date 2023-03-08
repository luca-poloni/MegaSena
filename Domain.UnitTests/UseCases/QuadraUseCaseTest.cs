using Domain.Factories;
using Domain.Interfaces;
using FluentAssertions;

namespace Domain.UnitTests.UseCases
{
    public sealed class QuadraUseCaseTest
    {
        [Fact]
        public void CalculateMethod_WithHundredAmount_ShouldBeFifty()
        {
            #region Arrange
            var quadraBet = 4;
            var gameRule = new GameRuleMock();
            var prize = PrizeFactory.Create(quadraBet, gameRule);
            #endregion

            #region Act
            var prizeValue = prize.Calculate();
            #endregion

            #region Assert
            prizeValue.Should().Be(50);
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
