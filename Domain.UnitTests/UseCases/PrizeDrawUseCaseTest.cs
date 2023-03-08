using Domain.Factories;
using FluentAssertions;

namespace Domain.UnitTests.UseCases
{
    public sealed class PrizeDrawUseCaseTest
    {
        [Fact]
        public void RaffleMethod_WithValidInstance_ShouldAsEnumerableInt()
        {
            #region Arrange
            var gameRule = GameRuleFactory.Create();
            var prizeDraw = PrizeDrawFactory.Create(gameRule);
            #endregion

            #region Act
            var hits = prizeDraw.Raffle();
            #endregion

            #region Assert
            hits.Should().As<IEnumerable<int>>();
            #endregion
        }
    }
}
