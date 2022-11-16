using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility__Right_version_
{
    public class UserAuthentication
    {
        //private PasswordValidator passwordValidator;
        //private EmailValidator emailValidator;

        //public UserAuthentication()
        //{
        //    passwordValidator = new PasswordValidator();
        //   emailValidator = new EmailValidator();
        //}
        public void Register(string email, string password)
        {
            //if (!emailValidator.ValidateEmail(email))
            //{
            //    throw new ArgumentException("Invalid email");
            //}
            //if (!passwordValidator.ValidatePassword(password))
            //{
            //    throw new ArgumentException("Invalid password");
            //}
            //20 lines of register user to datebase
        }
    }
}
