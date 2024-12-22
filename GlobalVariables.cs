using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CourtManagement
{
    public static class GlobalVariables
    {
        private static int UserId {  get; set; }
        private static int UserRole {  get; set; }
        public static void SetUserId(int userId)
        {
            UserId = userId;
        }
        public static void SetUserRole(int userRole)
        {
            UserRole = userRole;
        }
        public static int GetUserId()
        {
            return UserId;
        }
        public static int GetUserRole()
        {
            return UserRole;
        }
    }
}
