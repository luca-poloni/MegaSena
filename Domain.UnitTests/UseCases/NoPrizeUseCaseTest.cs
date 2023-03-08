using Domain.Factories;
using FluentAssertions;

namespace Domain.UnitTests.UseCases
{
    public sealed class NoPrizeUseCaseTest
    {
        [Fact]
        public void CalculateMethod_WithHundredAmount_ShouldBeZero()
        {
            #region Arrange
            var noPrizeBet = 0;
            var gameRule = GameRuleFactory.Create();
            var prize = PrizeFactory.Create(noPrizeBet, gameRule);
            #endregion

            #region Act
            var prizeValue = prize.Calculate();
            #endregion

            #region Assert
            prizeValue.Should().Be(decimal.Zero);
            #endregion
        }
    }
}
