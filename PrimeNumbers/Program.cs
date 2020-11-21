﻿using System;
using System.Collections.Generic;

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
            Console.Write("\nIt can also go from 0 to a number you pick, type y to continue or n to end the program ");
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
                    Console.WriteLine("Exiting..");
                    break;
            }
        }

        private static void Game()
        {
            string choice;
            var primeNumbers = new List<int>();
            do
            {
                Console.Write("Enter a number ");
                var range = int.Parse(Console.ReadLine());
                for (int i = 1; i <= range; i++)
                {
                    for (int j = i - 1; j > 0; j--)
                    {
                        if (j == 1)
                        {
                            primeNumbers.Add(i);
                        }
                        if (i % j != 0)
                        {
                            continue;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
                Console.Write("The prime numbers are: ");
                foreach (int number in primeNumbers)
                {
                    Console.Write($"{number} ");
                }
                Console.ReadLine();
                Console.Write("\nEnter y/yes to replay or any other character to exit ");
                choice = Console.ReadLine().ToLower();
                primeNumbers.Clear();
            } while (choice == "y" || choice == "yes");

            Console.WriteLine("Goodbye for now");
        }
    }
}