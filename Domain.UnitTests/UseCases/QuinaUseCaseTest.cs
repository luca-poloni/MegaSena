using Domain.Factories;
using Domain.Interfaces;
using FluentAssertions;

namespace Domain.UnitTests.UseCases
{
    public sealed class QuinaUseCaseTest
    {
        [Fact]
        public void CalculateMethod_WithHundredAmount_ShouldBeEighty()
        {
            #region Arrange
            var quinaBet = 5;
            var gameRule = new GameRuleMock();
            var prize = PrizeFactory.Create(quinaBet, gameRule);
            #endregion

            #region Act
            var prizeValue = prize.Calculate();
            #endregion

            #region Assert
            prizeValue.Should().Be(80);
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
