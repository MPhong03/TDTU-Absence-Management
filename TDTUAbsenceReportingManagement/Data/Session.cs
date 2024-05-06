using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDTUAbsenceReportingManagement.Data
{
    public static class Session
    {
        private static string userid;
        private static string username;
        private static string userrole;

        public static string UserID
        {
            get { return userid; }
        }
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

        public static void Login(string id, string user, string role)
        {
            userid = id;
            username = user;
            userrole = role;
        }

        public static void Logout()
        {
            userid = null;
            username = null;
            userrole = null;
        }
    }
}
