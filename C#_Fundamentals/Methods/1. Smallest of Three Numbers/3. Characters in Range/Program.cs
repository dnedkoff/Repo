﻿namespace _3._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char start = char.Parse(Console.ReadLine());
            char end = char.Parse(Console.ReadLine());
            PrintCharacters(start,end);
        }
        static void PrintCharacters(char start, char end)
        {
            if (start <)
            {

            }
            for (int i = start + 1; i < end; i++)
            {
                Console.Write($"{(char)i}" + " ");
            }
            
        }
    }
}