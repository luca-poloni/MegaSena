using Domain.Factories;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Application.Handles
{
    public sealed class GameHandle
    {
        private IEnumerable<int> _betNumbers;

        public GameHandle(IEnumerable<int> betNumbers)
        {
            _betNumbers = betNumbers;
        }

        public ActionResult<IGameResult> Handle()
        {
            ActionResult<IGameResult> result;

            try
            {
                var gameRule = GameRuleFactory.Create();
                var bet = BetFactory.Create(_betNumbers, gameRule);
                var prizeDraw = PrizeDrawFactory.Create(gameRule);
                var game = GameFactory.Create(bet, prizeDraw, gameRule);
                result = new ActionResult<IGameResult>(game.Play());
            }
            catch (Exception ex)
            {
                result = new BadRequestObjectResult(ex.Message);
            }

            return result;
        }
    }
}
