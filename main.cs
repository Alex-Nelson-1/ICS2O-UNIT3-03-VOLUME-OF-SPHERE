// Created by: Alex Nelson
// Created on: Oct 2022
//
// This program calculates volume of a sphere
using System;

class Program
{
    public static void Main(string[] args)
    {
        //Input
        double radius;
        double volume;
        Console.WriteLine("This program calculates the volume of a sphere");
        Console.WriteLine("\nEnter radius in cm: ");
        radius = Convert.ToDouble(Console.ReadLine());
        //Proccess
        volume = 4.0 / 3.0 * Math.PI * Math.Pow(radius, 3);
        //Output
        Console.WriteLine("");
        Console.WriteLine("The volume is: " + volume + " cm³");
        Console.WriteLine("\nDone");
    }
}
