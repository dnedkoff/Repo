using System;
using System.Linq;

namespace _7._Max_Sequence_of_Equal_Elements
{
    /* 
    Create a program that finds the longest sequence of equal elements in an array of integers. 
    If several equal sequences are present in the array, print out the leftmost one.
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int sequenceCounter = 1;
            int longerSequence = 0;
            int element = 0;

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                if (inputArray[i] == inputArray[i + 1])
                {
                    sequenceCounter++;
                }
                else
                {
                    sequenceCounter = 1;
                }

                if (sequenceCounter > longerSequence)
                {
                    longerSequence = sequenceCounter;
                    element = inputArray[i];
                }
            }
            for (int j = 1; j <= longerSequence; j++)
            {
                Console.Write($"{element} ");
            }
        }
    }
}