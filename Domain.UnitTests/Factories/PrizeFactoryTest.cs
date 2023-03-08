using Domain.Factories;
using Domain.Interfaces;
using FluentAssertions;

namespace Domain.UnitTests.Factories
{
    public sealed class PrizeFactoryTest
    {
        private readonly IGameRule _gameRuleMock;

        public PrizeFactoryTest()
        {
            _gameRuleMock = GameRuleFactory.Create();
        }

        [Fact]
        public void CreatePrize_WithQuadraParameters_ShouldAsPrize()
        {
            #region Arrange
            var quadraHits = 4;
            #endregion

            #region Act
            var prize = PrizeFactory.Create(quadraHits, _gameRuleMock);
            #endregion

            #region Assert
            prize.Should().As<IPrize>();
            #endregion
        }

        [Fact]
        public void CreatePrize_WithQuinaParameters_ShouldAsPrize()
        {
            #region Arrange
            var quinaHits = 5;
            #endregion

            #region Act
            var prize = PrizeFactory.Create(quinaHits, _gameRuleMock);
            #endregion

            #region Assert
            prize.Should().As<IPrize>();
            #endregion
        }

        [Fact]
        public void CreatePrize_WithSenaParameters_ShouldAsPrize()
        {
            #region Arrange
            var senaHits = 6;
            #endregion

            #region Act
            var prize = PrizeFactory.Create(senaHits, _gameRuleMock);
            #endregion

            #region Assert
            prize.Should().As<IPrize>();
            #endregion
        }

        [Fact]
        public void CreatePrize_WithNoPrizeParameters_ShouldAsPrize()
        {
            #region Arrange
            var noPrizeHits = 0;
            #endregion

            #region Act
            var prize = PrizeFactory.Create(noPrizeHits, _gameRuleMock);
            #endregion

            #region Assert
            prize.Should().As<IPrize>();
            #endregion
        }
    }
}
