using System;

namespace VariablesAndOperators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //TODO Create a program that asks for a number

            Console.WriteLine("Please enter a number.");
            int userNumber = int.Parse(Console.ReadLine());

            //TODO Take that number as an input and using a ternary operator respond with if that number is even or odd.

            var isEven = (userNumber % 2 == 0) ? "Your number is even." : "Your number is odd.";
            Console.WriteLine(isEven);

            //TODO Assign the value of the double below to an int variable called "priceRounded". google "w3schools C# type casting"

            double price = 15.99;
            int priceRounded = (int) price;
            Console.WriteLine(priceRounded);

        }
    }
}
