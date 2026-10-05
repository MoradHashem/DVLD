using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDBusinessLayer;

namespace DVLDBusinessLayer
{
    public class clsLoginInformation
    {
        public static string UserName = "Abdo772";
        public static string Password = "Abdo772";
        public static bool RememberMe = true;


        private static clsUsers _User;

        public static clsUsers GetUser()
        {
            _User = clsUsers.FindUserByUserName(UserName);

            return _User;
        }


    }
}
