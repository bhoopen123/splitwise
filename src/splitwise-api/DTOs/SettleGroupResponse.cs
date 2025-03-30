using System.Transactions;

namespace Splitwise.Api.DTOs
{
    public record SettleGroupResponse
    {
        public required ResponseStatus ResponseStatus { get; init; }
        public required string Message { get; init; }

        public IEnumerable<Transaction>? Transactions { get; set; }
    }

    public enum ResponseStatus
    {
        Success,
        Failure
    }
}
