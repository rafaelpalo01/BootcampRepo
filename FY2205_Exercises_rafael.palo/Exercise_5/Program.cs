// <copyright file="Program.cs" company="Exercise 5, May 25, 2022">
// Copyright (c) Exercise 5, May 25, 2022. All rights reserved.
// </copyright>

namespace Exercise_5
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.Beep();
                int a, b;
                int num1, num2;
                int[] array1 = new int[10];
                for (a = 0; a < 10; a++)
                {
                    Console.WriteLine("Input Number ");
                    array1[a] = int.Parse(Console.ReadLine());
                }
                for (a = 0; a < 10; a++)
                {
                    for (b = 0; b < 9; b++)
                    {
                        if (array1[b] > array1[b + 1])
                        {
                            int c = array1[b + 1];
                            array1[b + 1] = array1[b];
                            array1[b] = c;

                        }
                    }
                }
                
                // For Ascending Order
                Console.WriteLine("\nAscending Order");
                for (a = 0; a < 10; a++)
                {
                    Console.WriteLine(array1[a] + " ");
                }

                {
                    for (a = 0; a < 10; a++)
                    {
                        for (b = 0; b < 9; b++)
                        {
                            if (array1[b] < array1[b + 1])
                            {
                                int c = array1[b + 1];
                                array1[b + 1] = array1[b];
                                array1[b] = c;
                            }
                        }
                    }
                    
                    // For Descending Order
                    Console.WriteLine("Descending Order");
                    for (a = 0; a < 10; a++)
                    {
                        Console.Write(array1[a] + " ");

                    }
                }
                Console.ReadKey();
            }
            catch (Exception)
            {

                Console.WriteLine("Error!!!");
            }
        }
    }
}
