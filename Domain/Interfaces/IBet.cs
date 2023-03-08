namespace Domain.Interfaces
{
    public interface IBet
    {
        IEnumerable<int> Numbers { get; }
        int AmountHits(IEnumerable<int> raffledNumbers);
    }
}
