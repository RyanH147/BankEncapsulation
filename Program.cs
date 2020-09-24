using System;
using System.Collections.Generic;

namespace BankEncapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            //var account = new BankAccount();

            //Console.WriteLine("How much would you like to deposit?");

            //var amountToDeposit = double.Parse(Console.ReadLine());

            //account.Deposit(amountToDeposit);

            //Console.WriteLine($"Thank you! Your balance is now {account.GetBalance()}");

            //var ryansInfo = new PersonalInformation();
            var ryansInfo = new PersonalInformation();
            string number; // declare a variable
            long results;

            do
            {
                Console.WriteLine("What is your area code and telephone number?");
                Console.WriteLine("with the following format: 2051235555");
                number = Console.ReadLine(); //store user input

            } while (number.Length != 10 || !long.TryParse(number, out results));

            ryansInfo.NumberFormatted = number;
            Console.WriteLine(ryansInfo.NumberFormatted);

            Console.WriteLine($"{ ryansInfo.NumberFormatted }");

            //Console.WriteLine("What is your phone number starting with the area code?");
            
            //ryansInfo.NumberFormatted = Console.ReadLine();

            //Console.WriteLine($"Your new phone number is {ryansInfo.NumberFormatted}");


        }
    }
}
