using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility
{
    public class WrongUserAuthentication
    {
        public void Register(string email, string password)
        {
            throw new ArgumentException("Email is not a valid email");


            throw new ArgumentException("Password must contain six symbols");
        }

        public void GetReportForAllUsers()
        {

        }
    }
}
