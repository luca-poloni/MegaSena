namespace Domain.Exceptions
{
    internal sealed class InvalidBetException : Exception
    {
        private const string DEFAULT_MESSAGE = "The bet is invalid.";
        public InvalidBetException() : base(DEFAULT_MESSAGE) { }
        public InvalidBetException(string message) : base(message) { }
    }
}
