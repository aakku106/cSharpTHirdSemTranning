namespace OnlineATM
{
    public class UserAccount
    {
        public string? UserId { get; set; } = string.Empty;
        public string? UserPassword { get; private set; } = string.Empty;
        public decimal? UserAmount { get; set; } = 0;

        public UserAccount(string userId, string userPassword)
        {
            UserId = userId;
            UserPassword = userPassword;
            UserAmount = 0;
        }
    }
}