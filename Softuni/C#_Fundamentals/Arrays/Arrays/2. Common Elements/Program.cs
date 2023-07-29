using System;

namespace _2._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Create a program that prints out all common elements in two arrays. 
            You have to compare the elements of the second array to the elements of the first.
            */

            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            for (int i = 0; i < secondArray.Length; i++)
            {
                for (int j = 0; j < firstArray.Length; j++)
                {
                    if (secondArray[i] == firstArray[j])
                    {
                        Console.Write(secondArray[i] + " ");
                    }
                }

                
            }
        }
    }
}