using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace RegularExpression
{
    class InputValidation
    {
        public void UserInput()
        {
            const string Regex_MobileNum = "^[1-9]{1,2}[ ][1-9]{1}[0-9]{9}$";
            Console.Write("\n Enter your mobile number (CountryCode 10DigitNumber) : ");
            string mobile = Console.ReadLine();

            if (Regex.IsMatch(mobile, Regex_MobileNum) == true)
            {
                Console.WriteLine(" Mobile number is Valid. ");
            }
            else
            {
                Console.WriteLine(" Mobile number is Not Valid. ");
                UserInput();
            }
        }
    }     }