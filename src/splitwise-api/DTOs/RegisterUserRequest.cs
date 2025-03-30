namespace Splitwise.DTOs
{
    public class RegisterUserRequest
    {
        public required string Name { get; set; }
        public required string Phone { get; set; }
        public required string Password { get; set; }
    }
}
