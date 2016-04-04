﻿using System;

//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

class Area
{
    static void Main(string[] args)
    {        
        double width = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        double area = width * height;
        double perimeter = 2*(width + height);
        Console.WriteLine("{0:F2} {1:F2}", area, perimeter);
    }
}