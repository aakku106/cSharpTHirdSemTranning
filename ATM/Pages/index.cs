using System.ComponentModel;

namespace OnlineATM
{
    public class Index
    {
        public string? UserId { get; set; } = string.Empty;
        public string? UserPassword { get; private set; } = string.Empty;
        public decimal UserAmount { get; private set; } = 0;
        public Index(string userId, string userPassword, decimal userAmount)
        {
            UserId = userId;
            UserPassword = userPassword;
            UserAmount = userAmount;
        }
    }
}