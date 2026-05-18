using System;
using System.Security.Cryptography;
using BC = BCrypt.Net.BCrypt;

namespace qldsv.Utils
{
    class SecurityHelper
    {
        public static string HashPassword(string plainText)
        {
            return BC.HashPassword(plainText, BC.GenerateSalt(12));
        }

        public static bool VerifyPassword(string plainText, string hash)
        {
            return BC.Verify(plainText, hash);
        }
    }
}