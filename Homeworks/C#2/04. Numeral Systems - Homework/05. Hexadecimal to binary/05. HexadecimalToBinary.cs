﻿using System;

//•	Write a program to convert hexadecimal numbers to their decimal representation.

class HexadecimalToBinary
{
    static void Main()
    {
        string number = Console.ReadLine();
        int numberBase = 16;
        int toBase = 2;
        string converted = Convert.ToString(Convert.ToInt32(number, numberBase), toBase);
        Console.WriteLine(converted);
    }
}

