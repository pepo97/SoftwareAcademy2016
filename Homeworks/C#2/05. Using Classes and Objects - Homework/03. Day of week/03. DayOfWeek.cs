﻿using System;

//•	Write a program that prints to the console which day of the week is today.
//•	Use System.DateTime.

class DayOfWeek
{
    static void Main()
    {
        var today = new DateTime();
        Console.WriteLine(today.DayOfWeek);

    }
}

