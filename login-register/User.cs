using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login_register
{
    public class User {
        //  Public class User implements the Singleton Design Pattern
        private static User userInstance;

        private string username;
        private string fullName;
        private string pfp;
        private bool is_author;

        //  Constructor is private
        private User() { 
            username = string.Empty;
            fullName = string.Empty;
            pfp = string.Empty;
            is_author = false;
        }

        //  The (only) user will be generated only if there is no other instance
        public static User RequestUser
        {
            get {
                if (userInstance == null)
                {
                   userInstance = new User();
                }
                return userInstance;
            }
        }

        public static string GetUsername() { return userInstance.username; }
        public static string GetFullName() { return userInstance.fullName; }
        public static string GetProfilePic() { return userInstance.pfp; }
        public static bool GetAuthor() { return userInstance.is_author; }

        //  Members can be assigned values only once. The new values persist throughout the program's execution
        public static void SetUsername(string username) { if (userInstance.username == string.Empty) userInstance.username = username; }
        public static void SetFullName(string fullName) { if (userInstance.fullName == string.Empty) userInstance.fullName = fullName; }
        public static void SetProfilePic(string pfp) { if (userInstance.pfp == string.Empty) userInstance.pfp = pfp; }
        public static void SetAuthor(bool is_author) { userInstance.is_author = is_author; }
    }
}
