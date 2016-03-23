﻿using System;
using System.Text;

//Problem 14.* Print the ASCII Table

//Find online more information about ASCII(American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console(characters from 0 to 255).
//Note: Some characters have a special purpose and will not be displayed as expected.You may skip them or display them differently.

//Note: You may need to use for-loops (learn in Internet how).


class AsciiTable
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        for (int i = 0; i < 256; i++)
        {
            Console.Write("DEC {0} HEX {1} ASCII {2}   ", i, i.ToString("X"), (char)i);

            if (i % 3 == 0)
            {
                Console.WriteLine();
            }
        }
    }
}
