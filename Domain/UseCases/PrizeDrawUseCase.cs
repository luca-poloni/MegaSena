using Domain.Interfaces;

namespace Domain.UseCases
{
    internal sealed class PrizeDrawUseCase : IPrizeDraw
    {
        private readonly IGameRule _gameRule;

        public PrizeDrawUseCase(IGameRule gameRule)
        {
            _gameRule = gameRule;
        }

        public IEnumerable<int> Raffle()
        {
            var drawnNumbers = new List<int>();
            var rand = new Random();

            for (int i = 0; i < _gameRule.AmountNumbers; i++)
            {
                int drawnNumber = rand.Next(_gameRule.MinimumNumber, _gameRule.MaximumNumber);

                while (drawnNumbers.Contains(drawnNumber))
                    drawnNumber = rand.Next(_gameRule.MinimumNumber, _gameRule.MaximumNumber);

                drawnNumbers.Add(drawnNumber);
            }

            return drawnNumbers;
        }
    }
}
