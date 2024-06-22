using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace pocketify.Authentication
{
    internal class PasswordHasher
    {
        // Hash the password using SHA256 method
        public static string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var salt = GenerateSalt();
                var saltedPassword = password + salt;
                var hash = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                return Convert.ToBase64String(hash) + ":" + salt;
            }
        }

        // Retrieve the given password hash from the database and check if it is correct.
        public static bool VerifyPassword(string enteredPassword, string storedHash)
        {
            var parts = storedHash.Split(':');
            var hash = parts[0];
            var salt = parts[1];
            using (var sha256 = SHA256.Create())
            {
                var saltedPassword = enteredPassword + salt;
                var enteredHash = sha256.ComputeHash(Encoding.UTF8.GetBytes(saltedPassword));
                return Convert.ToBase64String(enteredHash) == hash;
            }
        }

        // Doesnt know much of whats going on here. 
        private static string GenerateSalt()
        {
            var buffer = new byte[16];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(buffer);
            }
            return Convert.ToBase64String(buffer);
        }
    }
}
