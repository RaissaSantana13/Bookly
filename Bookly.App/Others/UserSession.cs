using Bookly.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookly.App.Others
{
    public static class UserSession
    {
        public static User? CurrentUser { get; set; }
        public static bool IsLoggedIn => CurrentUser != null;
        public static void Logout()
        {
            CurrentUser = null;
        }
    }
}
