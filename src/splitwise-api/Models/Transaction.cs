namespace Splitwise.Api.Models
{
    public class Transaction
    {
        public required string From { get; init; }
        public required string To { get; init; }
        public int Amount { get; init; }

        override public string ToString()
        {
            return $"{From} owes {To} {Amount}";
        }
    }
}
