﻿using System;

class Program
{
    static void Main()
    {
        int limit = 1000;
        int sum = 0;

        for (int i = 1; i < limit; i++)
        {
            if (i % 3 == 0 || i % 5 == 0)
            {
                sum += i;
            }
        }

        Console.WriteLine("The sum of multiples of 3 or 5 below 1000 is: " + sum);
    }
}
