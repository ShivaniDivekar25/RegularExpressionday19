﻿namespace RegularExpressionDay19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Programs");
            Console.WriteLine("Please enter the option given below");           //Taking user input
            Console.WriteLine("1:Create first name\n2:Create last name\n3:Create valid Email ID\n4:Create phone number with country code\n5:Create password Rule 1\n6:Create password Rule 2\n7:Create password Rule 3\n8:Create password Rule 4\n9:Create valid Emails");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)             //using switch case calling different method
            {
                case 1:
                    RegularExpression.fisrtName();
                    break;
                case 2:
                    RegularExpression.lastName();
                    break;
                case 3:
                    RegularExpression.validEmail();
                    break;
                case 4:
                    RegularExpression.phoneNumber();
                    break;
                case 5:
                    RegularExpression.password();
                    break;
                case 6:
                    RegularExpression.password();
                    break;
                case 7:
                    RegularExpression.password();
                    break;
                case 8:
                    RegularExpression.password();
                    break;
                case 9:
                    RegularExpression.validateEmails();
                    break;
                default:
                    Console.WriteLine("Please choose correct option");
                    break;
            }
        }
    }
}