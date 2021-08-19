using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class InputValidation
    {
        public void UserInput()
        {
            const string Regex_Password = "^(?=.*[a-z0-9A-Z])(?=.*[A-Z])(?=.*[0-9]).{8,}$";
            //(?=.*[A-Z]) - atleast 1 capital letter
            //(?=.*[0-9]) - atleast 1 number
            Console.WriteLine("\n Password Rules --> 1]Minimum 8 Characters\t2]At least 1 capital alphabet\t3]At least 1 number");
        }
    }     }