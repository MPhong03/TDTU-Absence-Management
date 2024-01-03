using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.DTO
{
    public static class SessionManager
    {
        public static string Username { get; private set; }
        public static string Role { get; private set; }
        public static void SetSession(string username, string role)
        {
            Username = username;
            Role = role;
        }
        public static void ClearSession()
        {
            Username = null;
            Role = null;
        }
    }
}
