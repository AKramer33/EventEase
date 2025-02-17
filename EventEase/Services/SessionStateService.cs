using System;

namespace EventEase.Services
{
    public class SessionStateService
    {
        public string UserName { get; set; } = string.Empty;
        public string UserEmail { get; set; } = string.Empty;

        // You can add more properties as needed
        public bool IsUserLoggedIn => !string.IsNullOrWhiteSpace(UserEmail);

        // Example: clear session
        public void ClearSession()
        {
            UserName = string.Empty;
            UserEmail = string.Empty;
        }
    }
}
