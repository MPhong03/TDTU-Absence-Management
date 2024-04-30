using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDTUAbsenceReportingManagement.Data
{
    public static class Session
    {
        private static string username;
        private static string userrole;

        public static string Username
        {
            get { return username; }
        }

        public static string Role
        {
            get { return userrole; }
        }

        public static bool IsLoggedIn
        {
            get { return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(userrole); }
        }

        public static void Login(string user, string role)
        {
            username = user;
            userrole = role;
        }

        public static void Logout()
        {
            username = null;
            userrole = null;
        }
    }
}
