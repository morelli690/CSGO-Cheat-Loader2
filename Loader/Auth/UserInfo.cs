using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth
{
    class UserInfo
    {
        public static bool Logged_In { get; set; }
        public static string ID { get; set; }
        public static string IP { get; set; }
        public static string Username { get; set; }
        public static string Password { get; set; }
        public static string HWID { get; set; }
        public static string Email { get; set; }
        public static string Variable { get; set; }
        public static string Rank { get; set; }
        public static string Expiry { get; set; }
    }
}
