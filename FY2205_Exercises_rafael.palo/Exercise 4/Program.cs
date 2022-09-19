// <copyright file="Program.cs" company="Exercise 4">
// Copyright (c) Exercise 4. All rights reserved.
// </copyright>

namespace Exercise_4
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            // Try Catch for error handling
            try
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                // Title of my Exercise
                Console.WriteLine("PARALLELOGRAM");
                int a, b, c, height;
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                // For inputting Value
                Console.WriteLine("\nInput Base Value from 4 to 10: ");
                height = int.Parse(Console.ReadLine());
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;

                if (height > 3 && height <= 10)
                {
                    for (a = 0; a < height; a++)
                    {
                        for (b = 0; b < height - a; b++)
                        {
                            Console.Write(" ");
                        }

                        for (c = 0; c < height; c++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                }
                else
                {
                    // Error when inputing wrong base value!!!!!!
                    Console.WriteLine("!!!!!!!YOU CAN ONLY INPUT BASE VALUE FROM 4 to 10!!!!!!!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error!!!!!");
            }
        }
    }
}
