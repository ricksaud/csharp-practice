using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Password Validator!");



            while (true)
            {
                Console.Write("Please, provide you password:");
                string password = Console.ReadLine();

                List<string> errors = ValidatePassword(password);

                if (errors.Count == 0)
                {
                    Console.WriteLine("Password Accepted. Sucess!");
                    break;
                }
                else
                {
                    foreach (string error in errors)
                    {
                        Console.WriteLine(error);
                    }
                }
            }
         


            Console.ReadLine();
        }

        public static bool MinimunPasswordSize(string password)
        {
            if (password.Length >= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool HasUpperCase(string password) {


            bool hasUpper = false;

            foreach (char c in password)
            {

                if (char.IsUpper(c))
                {
                    hasUpper = true;
                }


               

            }
            return hasUpper;
        }


        public static bool HasLowerCase(string password)
        {


            bool hasLower = false;

            foreach (char c in password)
            {

                if (char.IsLower(c))
                {
                    hasLower = true;
                }




            }
            return hasLower;
        }


        public static bool HasNumber(string password)
        {
            bool hasNumber = false;


            foreach (char c in password)
            {

                if (char.IsDigit(c))
                {
                    hasNumber = true;
                }
            }

            return hasNumber;


        }


        public static bool HasSpecialChars(string password)
        {
            string special = "!@#$%^&*()";
            bool hasSpecialChars = false;

            foreach (char c in password)
            {

                if (special.Contains(c)){ 
                    hasSpecialChars = true;
                }

            }

            return hasSpecialChars;
        }



        public static List<string> ValidatePassword(string password)
        {
            List<string> errors = new List<string>();

            if (!MinimunPasswordSize(password))
            {
                errors.Add("Password must be at least 8 characters");
            } if(!HasUpperCase(password))
            {
                errors.Add("Password must have at least one Upper case character");
            }
            if (!HasLowerCase(password))
            {
                errors.Add("Password must have at least one lower case character");
            }
            if (!HasNumber(password))
            {
                errors.Add("Password must have at least one number");
            }
            if (!HasSpecialChars(password))
            {
                errors.Add("Password must have at least one special character");
            }

            return errors;
        }

    }
}
