
using Domain.Factories;
using Domain.Interfaces;
using FluentAssertions;

namespace Domain.UnitTests.UseCases
{
    public sealed class GameRuleUseCaseTest
    {
        private readonly IGameRule _gameRule;

        public GameRuleUseCaseTest()
        {
            _gameRule = GameRuleFactory.Create();
        }

        [Fact]
        public void AmountNumbersProperty_ShouldBeSix()
        {
            #region Act
            var amountNumbers = _gameRule.AmountNumbers;
            #endregion

            #region Assert
            amountNumbers.Should().Be(6); 
            #endregion
        }

        [Fact]
        public void MinimumNumberProperty_ShouldBeOne()
        {
            #region Act
            var minimumNumber = _gameRule.MinimumNumber;
            #endregion

            #region Assert
            minimumNumber.Should().Be(1);
            #endregion
        }

        [Fact]
        public void MaximumNumberProperty_ShouldBeSixty()
        {
            #region Act
            var maximumNumber = _gameRule.MaximumNumber;
            #endregion

            #region Assert
            maximumNumber.Should().Be(60);
            #endregion
        }

        [Fact]
        public void AmountNumberProperty_ShouldBeSixMillion()
        {
            #region Act
            var amount = _gameRule.Amount;
            #endregion

            #region Assert
            amount.Should().Be(6000000M);
            #endregion
        }
    }
}
