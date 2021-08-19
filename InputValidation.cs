using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class InputValidation
    {
        public void UserInput()
        {
            const string Regex_Password = "^(?=.*[a-z0-9A-Z])(?=.*[A-Z]).{8,}$";
            //(?=.*[A-Z]) - atleast 1 capital letter
            Console.WriteLine("\n Password Rules --> 1]Minimum 8 Characters\t2]At least 1 capital alphabet");
            Console.Write("\n Enter password : ");
            string password = Console.ReadLine();
        }
    }     }