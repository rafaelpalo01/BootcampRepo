// <copyright file="Program.cs" company="Exercise 6 | June 2, 2022">
// Copyright (c) Exercise 6 | June 2, 2022. All rights reserved.
// </copyright>

namespace Exercise_6
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                // Fix Value of 5 input!!!!!!
                int[] array1 = new int[5];
                // Already entered the value
                array1[0] = 1;
                array1[1] = 2;
                array1[2] = 4;
                array1[3] = 6;
                array1[4] = 5;
                // Instantiating Method Class!!!
                method expectedOutput = new method();
                // The OUTPUT!!!!
                Console.WriteLine("The Output is " + expectedOutput.Method(array1));
            }
            catch (Exception)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}
