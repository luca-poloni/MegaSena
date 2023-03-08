using Domain.Factories;
using Domain.Interfaces;

namespace Domain.UseCases
{
    internal sealed class GameUseCase : IGame
    {
        private readonly IBet _bet;
        private readonly IPrizeDraw _prizeDraw;
        private readonly IGameRule _gameRule;

        public GameUseCase(IBet bet, IPrizeDraw prizeDraw, IGameRule gameRule)
        {
            _bet = bet;
            _prizeDraw = prizeDraw;
            _gameRule = gameRule;
        }

        public IGameResult Play()
        {
            var raffledNumbers = _prizeDraw.Raffle();
            var hits = _bet.AmountHits(raffledNumbers);
            var prize = PrizeFactory.Create(hits, _gameRule);
            var prizeValue = prize.Calculate();

            return GameResultFactory.Create(_gameRule.Amount, _bet.Numbers, raffledNumbers, hits, prizeValue);
        }
    }
}
