using Splitwise.Api.DTOs;

namespace Splitwise.DTOs
{
    public class UserResponse
    {
        public long UserId { get; set; }
        public required string Name { get; set; }
        public required string Phone { get; set; }
        public required ResponseStatus ResponseStatus { get; init; }
        public required string Message { get; init; }
    }
}
