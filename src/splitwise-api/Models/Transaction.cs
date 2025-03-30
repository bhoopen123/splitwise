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

    public class BaseModel
    {
        public long Id { get; set; }
        public DateTime CreatedAtUtc { get; set; }
        public DateTime ModifiedAtUtc { get; set; }
    }

    public class User : BaseModel
    {
        public required string Name { get; set; }
        public required string Phone { get; set; }
        public required string Password { get; set; }
    }
}
