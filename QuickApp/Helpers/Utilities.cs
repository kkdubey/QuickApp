// =============================
// Email: kkdubey1989@gmail.com
// https://github.com/kkdubey
// =============================

using IdentityModel;
using System;
using System.IO;
using System.Linq;
using System.Security.Claims;

namespace QuickApp.Helpers
{
    public static class Utilities
    {
        public static void QuickLog(string text, string logPath)
        {
            string dirPath = Path.GetDirectoryName(logPath);

            if (!Directory.Exists(dirPath))
                Directory.CreateDirectory(dirPath);

            using StreamWriter writer = File.AppendText(logPath);
            writer.WriteLine($"{DateTime.Now} - {text}");
        }



        public static string GetUserId(ClaimsPrincipal user)
        {
            return user.FindFirst(JwtClaimTypes.Subject)?.Value?.Trim();
        }



        public static string[] GetRoles(ClaimsPrincipal identity)
        {
            return identity.Claims
                .Where(c => c.Type == JwtClaimTypes.Role)
                .Select(c => c.Value)
                .ToArray();
        }
    }
}
