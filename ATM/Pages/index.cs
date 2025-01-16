namespace OnlineATM
{
    public class UserAccount
    {
        public string? UserId { get; set; } = string.Empty;
        public string? UserPassword { get; private set; } = string.Empty;

        public UserAccount(string userId, string userPassword)
        {
            UserId = userId;
            UserPassword = userPassword;
        }
    }


    public class ShowUserDetails
    {
        public decimal UserAmount { get; private set; }
        public ShowUserDetails(decimal money)
        {
            UserAmount = money;
        }
    }
}