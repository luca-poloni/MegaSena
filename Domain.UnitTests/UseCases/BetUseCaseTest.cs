using Domain.Factories;
using Domain.Interfaces;
using FluentAssertions;

namespace Domain.UnitTests.UseCases
{
    public sealed class BetUseCaseTest
    {
        private readonly IGameRule _gameRuleMock;

        public BetUseCaseTest()
        {
            _gameRuleMock = GameRuleFactory.Create();
        }

        [Fact]
        public void CreateBet_WithValidBetNumbers_ShouldNotThrow()
        {
            Action action = () =>
            {
                var betNumbers = new List<int> { 10, 20, 30, 40, 50, 60 };
                var bet = BetFactory.Create(betNumbers, _gameRuleMock);
            };

            action.Should()
                .NotThrow();
        }

        [Fact]
        public void CreateBet_WithInvalidMaximumNumber_ShouldThrowExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var invalidMaximumNumber = 61;
                var betNumbers = new List<int> { 10, 20, 30, 40, 50, invalidMaximumNumber };
                var bet = BetFactory.Create(betNumbers, _gameRuleMock);
            };

            action.Should()
                 .Throw<Exception>().WithMessage("One or more numbers have a value greater than allowed.");
        }

        [Fact]
        public void CreateBet_WithInvalidMinimumNumber_ShouldThrowExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var invalidMinimumNumber = 0;
                var betNumbers = new List<int> { 10, 20, 30, 40, 50, invalidMinimumNumber };
                var bet = BetFactory.Create(betNumbers, _gameRuleMock);
            };

            action.Should()
                 .Throw<Exception>().WithMessage("One or more numbers have their value less than allowed.");
        }

        [Fact]
        public void CreateBet_WithRepeatedNumber_ShouldThrowExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var repeatedNumber = 10;
                var betNumbers = new List<int> { 10, 20, 30, 40, repeatedNumber, repeatedNumber };
                var bet = BetFactory.Create(betNumbers, _gameRuleMock);
            };

            action.Should()
                 .Throw<Exception>().WithMessage("One or more numbers are repeated.");
        }

        [Fact]
        public void CreateBet_WithInvalidAmountNumbers_ShouldThrowExceptionWithSpecificMessage()
        {
            Action action = () =>
            {
                var surplusNumber = 43;
                var betNumbers = new List<int> { 10, 20, 30, 40, 41, 42, surplusNumber };
                var bet = BetFactory.Create(betNumbers, _gameRuleMock);
            };

            action.Should()
                 .Throw<Exception>().WithMessage("Amount of numbers is invalid.");
        }

        [Fact]
        public void AmountHitsMethod_WithFourNumbersDrawn_ShouldBeFourHits()
        {
            #region Arrange
            var raffledNumbers = new List<int> { 10, 20, 30, 40, 41, 42 };
            var betNumbers = new List<int> { 10, 20, 30, 40, 50, 60 };
            var bet = BetFactory.Create(betNumbers, _gameRuleMock);
            #endregion

            #region Act
            var hits = bet.AmountHits(raffledNumbers);
            #endregion

            #region Assert
            hits.Should().Be(4); 
            #endregion
        }
    }
}
