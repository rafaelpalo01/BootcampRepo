// <copyright file="Program.cs" company="Exercise 3 Upside Down Triangle">
// Copyright (c) Exercise 3 Upside Down Triangle. All rights reserved.
// </copyright>

namespace Exercise_3
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("UPSIDE DOWN TRIANGLE\n");
                Console.Beep();
                int height, a, b, height1;
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;

                // Inputting the height of triangle
                Console.WriteLine("Enter the Height of the UPSIDE DOWN TRIANGLE: ");
                height = Convert.ToInt32(Console.ReadLine());
               
                // if else statement for the Range of height
                // Height range from 1 to 20 only
                if (height <= 20)
                {
                    height1 = height;
                    for (a = 1; a <= height; a++)
                    {
                        for (b = 1; b < a; b++)
                        {
                            Console.Write(" ");
                        }
                        for (b = 1; b <= ((height * 2) - ((2 * a) - 1)); b++)
                        {
                            Console.Write("*");
                        }
                        Console.Write("\n");
                    }
                }
                else
                {
                    Console.WriteLine("You can only enter height value from 1 to 20!!!!");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR!!!!");
            }
        }
    }
}
