using System.ComponentModel;

namespace OnlineATM
{


    public class Index
    {
        public static string UserId { get; set; } = string.Empty;
        private string UserPassword { get; set; } = string.Empty;
        private static decimal UserAmount { get; set; } = 0;

        public Index(string userId, string userPassword, decimal userAmount)
        {
            UserId = userId;
            UserPassword = userPassword;
            UserAmount = userAmount;
        }

    }
}