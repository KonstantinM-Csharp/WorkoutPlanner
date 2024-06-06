using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutPlanner.Services
{
    class UserManager
    {
        private static string _currentUser;
        public static string CurrentUser { get => _currentUser; set => _currentUser = value; }
        public static bool Login (string login, string password)
        {
            if (login == "admin" && password == "123456")
            {
                CurrentUser = "user";
                return true;
            }
            else return false;
        }
    }
}
