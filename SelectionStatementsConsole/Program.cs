using System;

namespace SelectionStatementsConsole
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");

            var subject = Console.ReadLine();

            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is a tough subject!");
                    break;

                case "science":
                    Console.WriteLine("Science is a tougher subject!");
                    break;

                case "pe":
                    Console.WriteLine("PE is a rough!");
                    break;

                case "history":
                    Console.WriteLine("History can get interesting");
                    break;

                case "english":
                    Console.WriteLine("Not my favorite subject");
                    break;

                default:
                    Console.WriteLine($"I haven't taken that subject before, {subject} sounds interesting");
                    break;
            }

       






        }
    }
}
