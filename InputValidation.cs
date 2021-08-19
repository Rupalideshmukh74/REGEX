using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class InputValidation
    {
        public void UserInput()
        {
            const string Regex_Password = "^[a-zA-Z0-9_!-+@#$]{8,}$";
            Console.WriteLine("\n Password Rule --> 1]Minimum 8 Characters");
            Console.Write("\n Enter password : ");
            string password = Console.ReadLine();

            if (Regex.IsMatch(password, Regex_Password) == true)
            {
                Console.WriteLine(" Password is in correct format. ");
            }
            else
            {
                Console.WriteLine(" Password is Not in correct format. ");
                UserInput();
            }
        }
    }     }