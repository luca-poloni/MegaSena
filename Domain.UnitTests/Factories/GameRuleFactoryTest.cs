using Domain.Factories;
using Domain.Interfaces;
using FluentAssertions;

namespace Domain.UnitTests.Factories
{
    public sealed class GameRuleFactoryTest
    {
        [Fact]
        public void CreateGameRule_ShouldAsGameRule()
        {
            #region Act
            var gameRule = GameRuleFactory.Create();
            #endregion

            #region Assert
            gameRule.Should().As<IGameRule>();
            #endregion
        }
    }
}
