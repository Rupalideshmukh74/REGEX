using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class InputValidation
    {
        public void UserInput()
        {
            const string Regex_EmailId = "^[A-Za-z0-9]+([.+-_][A-Za-z0-9]+)*[@][a-zA-Z0-9]+[.][A-Za-z]+([.][A-Za-z]+)?$";

            Console.Write(" Enter your email-Id : ");
            string email = Console.ReadLine();

            if (Regex.IsMatch(email, Regex_EmailId) == true)
            {
                Console.WriteLine(" Email Id - Valid");
            }
            else
            {
                Console.WriteLine(" Email Id - Not valid");
                UserInput();
            }
        }
    }     }