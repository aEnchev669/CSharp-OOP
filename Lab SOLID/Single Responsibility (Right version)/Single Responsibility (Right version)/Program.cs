using System;

namespace Single_Responsibility__Right_version_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your email?");
            string email = Console.ReadLine();
            Console.WriteLine("What is your password?");
            string password = Console.ReadLine();

            EmailValidator emailValidator = new EmailValidator();
            PasswordValidator passwordValidator = new PasswordValidator();
            UserAuthentication user = new UserAuthentication();

            if (emailValidator.ValidateEmail(email) && passwordValidator.ValidatePassword(password) )
            {
                user.Register(email, password);
            }

        }
    }
}
