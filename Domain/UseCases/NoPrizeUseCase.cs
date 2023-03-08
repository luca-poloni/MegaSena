using Domain.Interfaces;

namespace Domain.UseCases
{
    internal sealed class NoPrizeUseCase : IPrize
    {
        public decimal Calculate()
        {
            return decimal.Zero;
        }
    }
}
