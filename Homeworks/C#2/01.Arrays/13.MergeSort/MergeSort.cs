﻿using System;

class MergeSort
{

    public static void MainMerge(int[] numbers, int left, int mid, int right)
    {
        int[] temp = new int[right + 1];
        int i, eol, num, pos;

        eol = (mid - 1);
        pos = left;
        num = (right - left + 1);

        while ((left <= eol) && (mid <= right))
        {
            if (numbers[left] <= numbers[mid])
                temp[pos++] = numbers[left++];
            else
                temp[pos++] = numbers[mid++];
        }

        while (left <= eol)
            temp[pos++] = numbers[left++];

        while (mid <= right)
            temp[pos++] = numbers[mid++];

        for (i = 0; i < num; i++)
        {
            numbers[right] = temp[right];
            right--;
        }
    }

    static public void SortMerge(int[] numbers, int left, int right)
    {
        int mid;

        if (right > left)
        {
            mid = (right + left) / 2;
            SortMerge(numbers, left, mid);
            SortMerge(numbers, (mid + 1), right);

            MainMerge(numbers, left, (mid + 1), right);
        }
    }

    static void Main(string[] args)
    {      
        int max = int.Parse(Console.ReadLine());
        int[] numbers = new int[max];
        for (int i = 0; i < max; i++)
        {           
            numbers[i] = int.Parse(Console.ReadLine());
        }       
        SortMerge(numbers, 0, max - 1);
        for (int i = 0; i < max; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }
}

