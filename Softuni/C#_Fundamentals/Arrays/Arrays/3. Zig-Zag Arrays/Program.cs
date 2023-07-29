using System;
using System.Linq;

namespace _3._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstArray = new int[n];
            int[] secondArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                string[] inputArr  = new string[2];
                inputArr = Console.ReadLine().Split(' ');

                if (i % 2 == 0)
                {
                    firstArray[i] = int.Parse(inputArr[0]);  
                    secondArray[i] = int.Parse(inputArr[1]);  

                }
                else
                {
                    firstArray[i] = int.Parse(inputArr[1]);
                    secondArray[i] = int.Parse(inputArr[0]);
                }
            }
            Console.WriteLine(string.Join(' ', firstArray));
            Console.WriteLine(string.Join(' ', secondArray));
        }
    }
}