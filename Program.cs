using System;

namespace RegularExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Resistation program");
            InputValidation validate = new InputValidation();
            validate.UserInput();
        }
    }
}
