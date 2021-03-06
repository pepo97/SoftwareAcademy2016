﻿using System;

//Problem 11. Bitwise: Extract Bit #3

//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

class BooleanExpression
{
    static void Main()
    {
        int checkNum = int.Parse(Console.ReadLine());
        int position = 3;
        int mask = 1 << position;
        int result = checkNum & mask;
        if (result == 8)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(0);
        }
        
    }
}
