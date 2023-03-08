using Domain.Factories;
using Domain.Interfaces;
using FluentAssertions;

namespace Domain.UnitTests.Factories
{
    public sealed class PrizeDrawFactoryTest
    {
        [Fact]
        public void CreatePrizeDraw_WithValidParameters_ShouldAsPrizeDraw()
        {
            #region Arrange
            var gameRule = GameRuleFactory.Create();
            #endregion

            #region Act
            var prizeDraw = PrizeDrawFactory.Create(gameRule);
            #endregion

            #region Assert
            prizeDraw.Should().As<IPrizeDraw>();
            #endregion
        }
    }
}
