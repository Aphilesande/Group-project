using System;
using System.Collections.Generic;

namespace Group_project
{
    /// <summary>
    /// UserStore - Simple in-memory account storage.
    /// Stores registered email/password pairs for the current session.
    ///
    /// NOTE: For a real production application, passwords should be hashed
    /// (e.g. using BCrypt or PBKDF2) and stored in a database, not kept
    /// in memory as plain text. This implementation is appropriate for a
    /// university project demonstrating the login/sign-up flow.
    /// </summary>
    internal static class UserStore
    {
        // Dictionary: email (lowercase) -> password
        private static readonly Dictionary<string, string> _users =
            new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Register a new user. Email comparison is case-insensitive.
        /// </summary>
        public static void AddUser(string email, string password)
        {
            _users[email.Trim().ToLower()] = password;
        }

        /// <summary>
        /// Check if an email address already has a registered account.
        /// </summary>
        public static bool EmailExists(string email)
        {
            return _users.ContainsKey(email.Trim().ToLower());
        }

        /// <summary>
        /// Validate login credentials.
        /// Returns true only if the email exists AND the password matches exactly.
        /// </summary>
        public static bool ValidateUser(string email, string password)
        {
            string key = email.Trim().ToLower();
            return _users.ContainsKey(key) && _users[key] == password;
        }
    }
}
