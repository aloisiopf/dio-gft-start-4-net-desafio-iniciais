﻿using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int inicio = 1;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"{Math.Pow(i,1)} {Math.Pow(i,2)} {Math.Pow(i,3)}");
            }
        }
    }
}