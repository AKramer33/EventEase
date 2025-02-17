using System.Collections.Generic;

namespace EventEase.Services
{
    public class AttendanceTrackerService
    {
        // For demo, store registrations in memory
        private readonly List<UserRegistration> _registrations = new();

        public void RegisterUser(string userName, string userEmail)
        {
            // Avoid duplicates (optional)
            var existing = _registrations.Find(r => r.Email == userEmail);
            if (existing == null)
            {
                _registrations.Add(new UserRegistration
                {
                    Name = userName,
                    Email = userEmail
                });
            }
        }

        public bool IsUserRegistered(string userEmail)
        {
            return _registrations.Exists(r => r.Email == userEmail);
        }

        // Add more methods to track event attendance, e.g., a dictionary of event => list of users
        // For example:
        //   public void MarkAttendance(string eventName, string userEmail) { ... }
        //   public IEnumerable<string> GetAttendees(string eventName) { ... }

        private class UserRegistration
        {
            public string Name { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
        }
    }
}
