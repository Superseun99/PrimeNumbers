using System;
using System.Collections.Generic;
using System.Threading;

namespace PrimeNumbers
{
    internal class Program
    {
        private static void Main()
        {
            WelcomeUser();
            ShowPrimeNumbers();
            SwitchModes();
            Close();
        }

        private static void WelcomeUser()
        {
            Console.WriteLine("This program displays the prime numbers from 0 to 1000...\n");
            Thread.Sleep(1000);
            Console.WriteLine("Here are the prime numbers below:");
        }

        private static void ShowPrimeNumbers()
        {
            var isPrime = true;
            for (var i = 2; i <= 1000; i++)
            {
                for (var j = 2; j <= 1000; j++)
                {
                    if (i == j || i % j != 0) continue;
                    isPrime = false;
                    break;
                    //  if (i != j && i % j == 0)
                    // {
                    // isPrime = false;
                    // break;
                    // }
                }
                if (isPrime)
                {
                    Console.Write($"\t{i}");
                }
                isPrime = true;
            }
            Thread.Sleep(2000);
        }

        private static void SwitchModes()
        {
            Console.Write("\n\nIt can also go from 0 to a number you pick, type y to continue or n to end the program ");
            var userChoice = Console.ReadLine()?.ToLower();
            switch (userChoice)
            {
                case "y":
                    Game();
                    break;

                case "n":
                    Console.WriteLine("Goodbye for now");
                    break;

                default:
                    Console.WriteLine("Exiting..");
                    break;
            }
        }

        private static void Game()
        {
            var primeNumbers = new List<int>();
            //var replay = true;
            string choice;
            do
            {
                Console.Write("Enter a number ");
                int range;
                try
                {
                    range = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                }
                catch (Exception)
                {
                    Console.WriteLine("range cannot be empty");
                    throw;
                }
                for (var i = 1; i <= range; i++)
                {
                    for (var j = i - 1; j > 0; j--)
                    {
                        if (j == 1)
                        {
                            primeNumbers.Add(i);
                        }
                        if (i % j == 0)
                        {
                            break;
                        }
                    }
                }

                Console.Write($"The prime numbers from 0 to {range} are: ");
                foreach (var number in primeNumbers)
                {
                    Console.Write($"{number} ");
                }
                Thread.Sleep(2000);
                Console.WriteLine("\nEnter y/yes to replay or any other character to exit ");
                choice = Console.ReadLine()?.ToLower();
                primeNumbers.Clear();
            } while (choice == "y" || choice == "yes");
        }

        private static void Close()
        {
            Console.WriteLine("Goodbye for now");
            Thread.Sleep(2000);
        }
    }
}