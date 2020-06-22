using System;

namespace SelectionStatementsConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!!!");
            Console.WriteLine("See if you can guess the correct number.");
            Console.WriteLine("What is the upper limit for the range of the number?");


            var userResponse = Console.ReadLine();

            var upperLimit = int.Parse(userResponse);


            var random = new Random();
            var favNumber = random.Next(1, upperLimit);

            Console.WriteLine("Input your guess:");

            var guess = int.Parse(Console.ReadLine());

            if (guess > favNumber)
            {
                Console.WriteLine("Your guess is too high! Sorry, try again.");
            }
            else if (guess < favNumber)
            {
                Console.WriteLine("Your guess is too low! Sorry, try again.");
            }
            else
            {
                Console.WriteLine("Correct!!!");
            }



        }
    }
}
