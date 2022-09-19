// <copyright file="Program.cs" company="Exercise1 Trapezoid">
// Copyright (c) Exercise1 Trapezoid. All rights reserved.
// </copyright>

namespace FY2205_Exercises_rafael.palo
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Inputing Trapezoids Sides and Height
                // Inputing Colors for the Text
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("TRAPEZOID");
                Console.Beep();
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                // All value is in METERS
                Console.WriteLine("\nValue is in METERS");
                Console.WriteLine("Enter Height of Trapezoid: ");
                string heightTrapezoid = Console.ReadLine();
                int numheight = Convert.ToInt32(heightTrapezoid);
                Console.Beep();
                Console.WriteLine("Enter Base A: ");
                string a = Console.ReadLine();
                int numa = Convert.ToInt32(a);
                Console.Beep();
                Console.WriteLine("Etnter Base B: ");
                string b = Console.ReadLine();
                int numb = Convert.ToInt32(b);
                Console.Beep();
                Console.WriteLine("Enter Leg A: ");
                string c = Console.ReadLine();
                int numc = Convert.ToInt32(c);
                Console.Beep();
                Console.WriteLine("Enter Leg B: ");
                string d = Console.ReadLine();
                int numd = Convert.ToInt32(d);
                // OUTPUT!!!!!!!!!!!!!
                // For the Perimeter of Trapezoid
                double numa1 = Convert.ToDouble(numa);
                double numb1 = Convert.ToDouble(numb);
                int sumPerimeter = numa + numb + numc + numd;
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\nPerimeter and Area of Trapezoid!");
                Console.WriteLine("Perimeter of Trapezoid = " + sumPerimeter + " meters");
                // For the Area of Trapezoid
                // For the average of two base lengths :)
                double averageBase = (numa1 + numb1) / 2;
                double areaTrapezoid = averageBase * numheight;
                Console.WriteLine("Area of Trapezoid = " + areaTrapezoid + " square meters");
            }
            catch (Exception)
            {
                Console.WriteLine("Error Occured!!!!");
            }
        }
    }
}
