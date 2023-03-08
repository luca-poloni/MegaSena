using Domain.Exceptions;
using Domain.Interfaces;
using FluentValidation;

namespace Domain.UseCases
{
    internal sealed class BetUseCase : IBet
    {
        public IEnumerable<int> Numbers { get; }

        public BetUseCase(IEnumerable<int> numbers, IGameRule gameRule)
        {
            Numbers = numbers;

            var validator = new BetValidation(gameRule);
            var result = validator.Validate(this);

            if (!result.IsValid)
                throw new InvalidBetException(result.ToString());
        }

        public int AmountHits(IEnumerable<int> raffledNumbers)
        {
            return Numbers.Intersect(raffledNumbers).Count();
        }

        private class BetValidation : AbstractValidator<BetUseCase>
        {
            public BetValidation(IGameRule gameRule)
            {
                RuleFor(x => x.Numbers)
                    .Must(x => !x.Any(x => x < gameRule.MinimumNumber)).WithMessage("One or more numbers have their value less than allowed.")
                    .Must(x => !x.Any(x => x > gameRule.MaximumNumber)).WithMessage("One or more numbers have a value greater than allowed.")
                    .Must(x => !x.GroupBy(x => x).Any(x => x.Count() > 1)).WithMessage("One or more numbers are repeated.")
                    .Must(x => x.Count() == gameRule.AmountNumbers).WithMessage("Amount of numbers is invalid.");
            }
        }
    }
}
