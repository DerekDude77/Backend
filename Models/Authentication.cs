using System;
using System.Collections.Generic;

namespace IntexDatabaseConnection.Models
{
    public partial class Authentication
    {
        public long UserId { get; set; }
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Firstname { get; set; }
        public string? Lastname { get; set; }
        public bool Role { get; set; }
    }
}
