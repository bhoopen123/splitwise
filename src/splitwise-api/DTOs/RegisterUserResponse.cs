﻿using Splitwise.Api.DTOs;

namespace Splitwise.DTOs
{
    public class RegisterUserResponse
    {
        public long UserId { get; set; }
        public required string UserName { get; set; }
        public required string PhoneNumber { get; set; }
        public required ResponseStatus ResponseStatus { get; init; }
        public required string Message { get; init; }
    }
}
