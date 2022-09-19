// <copyright file="Program.cs" company="Exercise 2 Right Triangle">
// Copyright (c) Exercise 2 Right Triangle. All rights reserved.
// </copyright>

namespace Exercise_2
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Isosceles Right Triangle");
                Console.Beep();
                int a, b, heightTriangle;
                // Inputting the height of the triangle
                Console.WriteLine("\nEnter the Height of the Isosceles Right Triangle: ");
                heightTriangle = Convert.ToInt32(Console.ReadLine());
                // For making the loop
                for (a = 1; a <= heightTriangle; a++)
                {
                    for (b = 1; b <= a; b++)
                    {
                        Console.Write("* ");
                    }
                    Console.Write("\n");
                }
                Console.ReadKey();
            }
            catch (Exception)
            {

                Console.WriteLine("Error Occured!");
            }
        }
    }
}
