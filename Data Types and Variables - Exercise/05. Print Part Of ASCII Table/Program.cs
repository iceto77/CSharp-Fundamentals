﻿using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            for (char i = (char)startNumber; i <= endNumber; i++)
            {
                Console.Write($"{i} ");
            }
            //for (int i = startNumber; i <= endNumber; i++)
            //{
            //    Console.Write($"{(char)i} ");
            //}
        }
    }
}
