using System;

namespace PrimeNumbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //initialize condition
            bool isPrime = true;
            Console.WriteLine("This program displays the prime numbers from 0 to 1000...\n");
            Console.WriteLine("Here are the prime numbers below:");

            for (int i = 2; i <= 1000; i++)
            {
                for (int j = 2; j <= 1000; j++)
                {
                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    Console.Write("\t{0}", i);
                }
                isPrime = true;
            }
            Console.ReadLine();
            Console.Write("\n\nIt can also go from 0 to a number you pick, type y to continue or n to end the program ");
            var user_choice = Console.ReadLine().ToLower();
            switch (user_choice)
            {
                case "y":
                    Game();
                    break;

                case "n":
                    Console.WriteLine("Goodbye for now");
                    break;

                default:
                    Console.WriteLine("Goodbye for now");
                    break;
            }
        }

        private static void Game()
        {
            string choice;
            do
            {
                //Console.Write("Do you want to continue? ");
                //choice = Console.ReadLine().ToLower();
                Console.Write("Enter a number ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "y" || choice == "yes");

            Console.WriteLine("Goodbye for now");
        }
    }
}