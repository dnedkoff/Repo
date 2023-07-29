using System;

namespace _2._Sum_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            int integer = int.Parse(Console.ReadLine());
            char[] integerToCharArray = integer.ToString().ToCharArray();
            int sum = 0;

            for (int i = 0; i <= integerToCharArray.Length - 1; i++)
            {
                sum += int.Parse(integerToCharArray[i].ToString());
            }

            Console.WriteLine(sum);
        }
    }
}
